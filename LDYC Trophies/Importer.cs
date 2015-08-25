using System;
using System.Data;
using System.IO;
using System.Text;
using System.Data.SqlServerCe;

namespace LDYC_Trophies {
  class Importer {
    private static SqlCeConnection Connection {
      get {
        return new SqlCeConnection(Properties.Settings.Default.ConnectionString);
      }
    }

    public static string GetClasses() {
      return GetTable("tblClasses", "fldClassID", "fldName");
    }

    public static string GetTrophies() {
      return GetTable("tblTrophies", "fldTrophyID", "fldName", "fldCurrentClassID");
    }

    public static string GetWinners() {
      return GetTable("tblWinners");
    }

    private static string GetTable(string table, params string[] fields) {
      using (SqlCeConnection conn = Connection) {
        conn.Open();

        DataTable data = new DataTable();
        using (SqlCeDataAdapter ad = new SqlCeDataAdapter("", conn)) {
          if (fields == null || fields.Length == 0)
            fields = new string[] { "*" };
          ad.SelectCommand.CommandText = string.Format("SELECT {0} FROM {1}", string.Join(", ", fields), table);
          ad.Fill(data);
        }

        StringBuilder sb = new StringBuilder();

        foreach (DataColumn col in data.Columns) {
          sb.AppendFormat("{0}\t", col.ColumnName);
        }
        sb.AppendLine();

        foreach (DataRow row in data.Rows) {
          foreach (DataColumn col in data.Columns) {
            object val = row[col];
            if (val is string)
              val = string.Format("\"{0}\"", val);

            sb.AppendFormat("{0}\t", val);
          }

          sb.AppendLine();
        }

        return sb.ToString();
      }
    }

    public static void ImportWinners() {
      using (FileStream fs = new FileStream(@"Y:\LDYC\Winners.txt", FileMode.Open, FileAccess.Read)) {

        string[] headers;
        using (StreamReader reader = new StreamReader(fs)) {
          headers = reader.ReadLine().Split('\t');

          using (SqlCeConnection conn = Connection) {
            conn.Open();
            using (SqlCeTransaction trans = conn.BeginTransaction()) {

              using (SqlCeCommand comm = new SqlCeCommand()) {
                comm.CommandText = @"INSERT INTO tblWinners(fldTrophyID, fldClassID, fldYear,
fldSailNumber, fldHelm, fldOwner, fldCreated, fldCrew, fldNotes) VALUES(@fldTrophyID, @fldClassID, @fldYear,
@fldSailNumber, @fldHelm, @fldOwner, @fldCreated, '', '');
";
                comm.Parameters.Add("fldTrophyID", SqlDbType.Int);
                comm.Parameters.Add("fldClassID", SqlDbType.Int);
                comm.Parameters.Add("fldYear", SqlDbType.SmallInt);
                comm.Parameters.Add("fldSailNumber", SqlDbType.NVarChar);
                comm.Parameters.Add("fldHelm", SqlDbType.NVarChar);
                comm.Parameters.Add("fldOwner", SqlDbType.NVarChar);
                comm.Parameters.AddWithValue("fldCreated", DateTime.Now);
                comm.Connection = conn;
                comm.Transaction = trans;
                comm.Prepare();

                string line;
                while ((line = reader.ReadLine()) != null) {
                  string[] parts = line.Split('\t');
                  for (int i = 0; i < headers.Length; i++) {
                    comm.Parameters[headers[i]].Value = parts[i];
                  }

                  comm.ExecuteNonQuery();
                }
              }

              trans.Commit();
            }
          }

        }
      }


    }

  }
}
