using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using Siberix.PDF;
using Siberix.PDF.Layout;
using Siberix.PDF.Utils;
using LDYC_Trophies.TrophyDataSetTableAdapters;

namespace LDYC_Trophies {
  public partial class ReportCreator : Component {
    #region Constants
    private const float MM = 72f / 25.4f;

    private readonly SizeF A4Portrait = new SizeF(210 * MM, 297 * MM);

    private readonly SizeF A5Portrait = new SizeF(148.5f * MM, 210 * MM);

    private const float Margin = 10 * MM; // Margin is 10mm

    private readonly System.Drawing.Font TitleFont = new System.Drawing.Font("Tahoma", 16,
      System.Drawing.FontStyle.Bold, GraphicsUnit.Point);

    private readonly System.Drawing.Font CaptionFont = new System.Drawing.Font("Tahoma", 12,
      System.Drawing.FontStyle.Bold, GraphicsUnit.Point);

    private readonly System.Drawing.Font Font = new System.Drawing.Font("Tahoma", 12,
      System.Drawing.FontStyle.Regular, GraphicsUnit.Point);

    private readonly System.Drawing.Font WinnerFont = new System.Drawing.Font("Tahoma", 10,
      System.Drawing.FontStyle.Regular, GraphicsUnit.Point);

    private readonly System.Drawing.Font FooterFont = new System.Drawing.Font("Tahoma", 8,
      System.Drawing.FontStyle.Regular, GraphicsUnit.Point);
    #endregion

    #region Properties
    private TrophyDataSet.tblClassesDataTable Classes {
      get {
        return trophyDataSet.tblClasses;
      }
    }

    private TrophyDataSet.tblPhotosDataTable Photos {
      get {
        return trophyDataSet.tblPhotos;
      }
    }

    private TrophyDataSet.tblTrophiesDataTable Trophies {
      get {
        return trophyDataSet.tblTrophies;
      }
    }

    private TrophyDataSet.tblWinnersDataTable Winners {
      get {
        return trophyDataSet.tblWinners;
      }
    }
    #endregion

    #region Constructors
    public ReportCreator() {
      InitializeComponent();

      Init();
    }

    public ReportCreator(IContainer container) {
      container.Add(this);

      InitializeComponent();

      Init();
    }
    #endregion

    #region Methods
    private void AddTrophyPage(Document doc, TrophyDataSet.tblTrophiesRow trophy, ref int pageNumber) {
      // Create a new A4 portrait page and add to the document
      pageNumber++;
      Page page = new Page(A4Portrait.Width, A4Portrait.Height);
      doc.Pages.Content.Add(page);

      // Add a bookmark
      doc.Outlines.Content.Add(new Outline(trophy.fldName,
        new Siberix.PDF.Atoms.XYZDestination(page, page.Graphics.TranslateY(0)), true));

      Siberix.PDF.Layout.Table.Table table;

      table = CreateDetailsTable(page, trophy);
      table.Measure(page.Graphics);
      table.Draw(page.Graphics);

      // Winners table, 2mm below details table
      table = CreateWinnersTable(page, trophy, table.Top + table.Height + Px(2));

      TrophyDataSet.tblWinnersRow[] rows = (TrophyDataSet.tblWinnersRow[])Winners.Select(
        string.Format("[fldTrophyID] = {0}", trophy.fldTrophyID),
        "[fldYear] ASC");
      int rowIndex = 0;
      foreach (TrophyDataSet.tblWinnersRow winner in rows) {
        AddWinnerRow(table, winner);

        /* Table needs to be measured, if it's too tall, then we need to remove this row,
         * draw it on the current page, add a new page, create a new table, and the row to it
         */
        table.Measure(page.Graphics);
        if ((table.Top + table.Height + Px(5)) > (page.Height - Margin)) {
          table.Rows.Remove(rowIndex, 0);

          // Draw the winners, and the footer, increment the page number
          table.Measure(page.Graphics);
          table.Draw(page.Graphics);
          DrawFooter(page, pageNumber);
          page.Graphics.Flush();
          pageNumber++;

          // New page
          page = new Page(A4Portrait.Width, A4Portrait.Height);
          doc.Pages.Content.Add(page);

          table = CreateWinnersTable(page, trophy, Margin);
          AddWinnerRow(table, winner);
          rowIndex = 0;
        }

        rowIndex++;
      }

      table.Measure(page.Graphics);
      table.Draw(page.Graphics);
      DrawFooter(page, pageNumber);

      page.Graphics.Flush();
    }

    private void AddTrophyWinnerRow(Siberix.PDF.Layout.Table.Table table, TrophyDataSet.TrophyWinnersRow winner) {
      Siberix.PDF.Layout.Table.Row row;
      Siberix.PDF.Layout.Table.Cell cell;
      Siberix.PDF.Layout.Text.Text text;

      Siberix.PDF.Layout.Text.Style regular = new Siberix.PDF.Layout.Text.Style(WinnerFont, Brushes.Black);

      row = table.AddRow();
      // Year
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      cell.Width = Px(15);
      cell.WidthIsFixed = true;
      text = cell.AddText();
      text.Style = regular;
      text.AddContent(winner.fldYear.ToString());
      // Trophy
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      cell.Width = Px(60);
      cell.WidthIsFixed = true;
      text = cell.AddText();
      text.Style = regular;
      text.AddContent(winner.fldTrophyName);
      // Class
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      cell.Width = Px(25);
      cell.WidthIsFixed = true;
      text = cell.AddText();
      text.Style = regular;
      text.AddContent(winner.fldClassName);

      // Helm / Crew / Owner
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      text = cell.AddText();
      text.Style = regular;

      string helm = winner.fldHelm;
      if (winner.fldCrew.Length != 0) {
        if (helm.Length != 0)
          helm += " / ";
        helm += winner.fldCrew;
      }
      if (winner.fldOwner.Length != 0) {
        if (helm.Length != 0)
          helm += "\n";
        helm += "Owner: " + winner.fldOwner;
      }
      text.AddContent(helm);
    }

    private void AddWinnerRow(Siberix.PDF.Layout.Table.Table table, TrophyDataSet.tblWinnersRow winner) {
      Siberix.PDF.Layout.Table.Row row;
      Siberix.PDF.Layout.Table.Cell cell;
      Siberix.PDF.Layout.Text.Text text;

      Siberix.PDF.Layout.Text.Style regular = new Siberix.PDF.Layout.Text.Style(WinnerFont, Brushes.Black);

      row = table.AddRow();
      // Year
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      cell.Width = Px(15);
      cell.WidthIsFixed = true;
      text = cell.AddText();
      text.Style = regular;
      text.AddContent(winner.fldYear.ToString());
      // Sail #
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      cell.Width = Px(30);
      cell.WidthIsFixed = true;
      text = cell.AddText();
      text.Style = regular;
      text.AddContent(winner.fldSailNumber);
      // Helm
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      text = cell.AddText();
      text.Style = regular;
      text.AddContent(winner.fldHelm);
      // Owner
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      text = cell.AddText();
      text.Style = regular;
      text.AddContent(winner.fldOwner);
    }

    private Document CreateDocument() {
      Document doc = new Document();

      doc.Info.Author = Environment.UserName;
      doc.Info.Creator = "Siberix.PDF";

      doc.Options = DocumentOption.Compress | DocumentOption.Encode | DocumentOption.SubsetFonts;

      return doc;
    }

    private Siberix.PDF.Layout.Table.Table CreateDetailsTable(Page page, TrophyDataSet.tblTrophiesRow trophy) {
      Siberix.PDF.Layout.Table.Table table;
      Siberix.PDF.Layout.Table.Row row;
      Siberix.PDF.Layout.Table.Cell cell;
      Siberix.PDF.Layout.Text.Text text;

      Siberix.PDF.Layout.Text.Style regular = new Siberix.PDF.Layout.Text.Style(WinnerFont, Brushes.Black);

      // Details table
      table = new Siberix.PDF.Layout.Table.Table() {
        Left = Margin,
        Top = Margin,
        Width = page.Width - (2 * Margin)
      };

      // Header row
      row = table.AddRow();
      cell = row.AddCell();
      cell.TopPadding = cell.BottomPadding = Px(5);
      cell.TopBorder.Width = 1;
      cell.TopBorder.Color = Color.LightGray;
      text = cell.AddText();
      text.Alignment = TextAlignment.Center;
      text.Style = new Siberix.PDF.Layout.Text.Style(TitleFont, Brushes.Black);
      text.AddContent(trophy.fldName);

      // Donated
      row = table.AddRow();
      cell = row.AddCell();
      cell.BottomPadding = Px(2);
      text = cell.AddText();
      text.Style = regular;
      text.AddContent(string.Format("Donated by {0} in {1}", trophy.fldDonor, trophy.fldYearDonated));

      // Conditions
      row = table.AddRow();
      cell = row.AddCell();
      cell.WidthIsFixed = true;
      cell.Width = Px(25);
      cell.BottomPadding = Px(2);
      text = cell.AddText();
      text.Style = regular;
      text.AddContent("Conditions:");
      cell = row.AddCell();
      cell.BottomPadding = Px(2);
      text = cell.AddText();
      text.Style = regular;
      text.AddContent(trophy.fldConditions);

      // Details
      row = table.AddRow();
      cell = row.AddCell();
      cell.WidthIsFixed = true;
      cell.Width = Px(25);
      cell.BottomPadding = Px(2);
      text = cell.AddText();
      text.Style = regular;
      text.AddContent("Details:");
      cell = row.AddCell();
      cell.BottomPadding = Px(2);
      text = cell.AddText();
      text.Style = regular;
      text.AddContent(trophy.fldDetails);

      // Red book page
      if (trophy.fldRedBookPage != 0) {
        row = table.AddRow();
        cell = row.AddCell();
        cell.BottomPadding = Px(2);
        text = cell.AddText();
        text.Style = regular;
        text.AddContent(string.Format("Red book page #{0}", trophy.fldRedBookPage));
      }

      return table;
    }

    private Siberix.PDF.Layout.Table.Table CreateTrophyWinnersTable(Page page, string sailNumber, int count) {
      Siberix.PDF.Layout.Table.Table table;
      Siberix.PDF.Layout.Table.Row row;
      Siberix.PDF.Layout.Table.Cell cell;
      Siberix.PDF.Layout.Text.Text text;

      Siberix.PDF.Layout.Text.Style regular = new Siberix.PDF.Layout.Text.Style(WinnerFont, Brushes.Black);

      table = new Siberix.PDF.Layout.Table.Table() {
        Left = Margin,
        Top = Margin,
        Width = page.Width - (2 * Margin)
      };

      // Title
      row = table.AddRow();
      cell = row.AddCell();
      cell.TopPadding = Px(5);
      cell.BottomPadding = Px(1);
      cell.TopBorder.Width = 1;
      cell.TopBorder.Color = Color.LightGray;
      text = cell.AddText();
      text.Style = new Siberix.PDF.Layout.Text.Style(CaptionFont, Brushes.Black);
      text.Alignment = TextAlignment.Center;
      text.AddContent(string.Format("Trophies won by '{0}' ({1})", sailNumber, count));

      // Column titles
      row = table.AddRow();
      // Year
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      cell.Width = Px(15);
      cell.WidthIsFixed = true;
      text = cell.AddText();
      text.Style = regular;
      text.AddContent("Year");
      // Trophy
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      cell.Width = Px(60);
      cell.WidthIsFixed = true;
      text = cell.AddText();
      text.Style = regular;
      text.AddContent("Trophy");
      // Class
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      cell.Width = Px(25);
      cell.WidthIsFixed = true;
      text = cell.AddText();
      text.Style = regular;
      text.AddContent("Class");
      // Helm / Crew / Owner
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      text = cell.AddText();
      text.Style = regular;
      text.AddContent("Helm, Crew & Owner");

      return table;
    }

    private Siberix.PDF.Layout.Table.Table CreateWinnersTable(Page page, TrophyDataSet.tblTrophiesRow trophy, float top) {
      Siberix.PDF.Layout.Table.Table table;
      Siberix.PDF.Layout.Table.Row row;
      Siberix.PDF.Layout.Table.Cell cell;
      Siberix.PDF.Layout.Text.Text text;

      Siberix.PDF.Layout.Text.Style regular = new Siberix.PDF.Layout.Text.Style(WinnerFont, Brushes.Black);

      table = new Siberix.PDF.Layout.Table.Table() {
        Left = Margin,
        Top = top,
        Width = page.Width - (2 * Margin)
      };

      // Title
      row = table.AddRow();
      cell = row.AddCell();
      cell.TopPadding = (top == Margin ? Px(5) : Px(2));
      cell.BottomPadding = Px(1);
      cell.TopBorder.Width = 1;
      cell.TopBorder.Color = Color.LightGray;
      text = cell.AddText();
      text.Style = new Siberix.PDF.Layout.Text.Style(CaptionFont, Brushes.Black);
      text.Alignment = TextAlignment.Center;
      text.AddContent(trophy.fldName + " Winners");

      // Column titles
      row = table.AddRow();
      // Year
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      cell.Width = Px(15);
      cell.WidthIsFixed = true;
      text = cell.AddText();
      text.Style = regular;
      text.AddContent("Year");
      // Sail #
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      cell.Width = Px(30);
      cell.WidthIsFixed = true;
      text = cell.AddText();
      text.Style = regular;
      text.AddContent("Sail # / Name");
      // Helm
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      text = cell.AddText();
      text.Style = regular;
      text.AddContent("Helm");
      // Owner
      cell = row.AddCell();
      cell.BottomPadding = Px(1);
      text = cell.AddText();
      text.Style = regular;
      text.AddContent("Owner");

      return table;
    }

    private void DrawFooter(Page page, int number) {
      Siberix.PDF.Layout.Table.Table table = new Siberix.PDF.Layout.Table.Table() {
        Left = Margin,
        Top = page.Height - Margin,
        Width = page.Width - (2 * Margin)
      };

      Siberix.PDF.Layout.Text.Style style = new Siberix.PDF.Layout.Text.Style(FooterFont, Brushes.Black);

      Siberix.PDF.Layout.Table.Row row = table.AddRow();
      Siberix.PDF.Layout.Table.Cell cell;
      Siberix.PDF.Layout.Text.Text text;

      // Version cell
      cell = row.AddCell();
      cell.WidthPercentage = 33;
      cell.TopBorder.Color = Color.LightGray;
      cell.TopBorder.Width = 1;
      text = cell.AddText();
      text.Alignment = TextAlignment.Left;
      text.Style = style;
      text.AddContent("v." + System.Windows.Forms.Application.ProductVersion);

      // Page Number
      cell = row.AddCell();
      cell.WidthPercentage = 34;
      cell.TopBorder.Color = Color.LightGray;
      cell.TopBorder.Width = 1;
      text = cell.AddText();
      text.Alignment = TextAlignment.Center;
      text.Style = style;
      text.AddContent(string.Format("Page {0}", number));

      // Date
      cell = row.AddCell();
      cell.WidthPercentage = 33;
      cell.TopBorder.Color = Color.LightGray;
      cell.TopBorder.Width = 1;
      text = cell.AddText();
      text.Alignment = TextAlignment.Right;
      text.Style = style;
      text.AddContent(DateTime.Now.ToString("g"));

      table.Measure(page.Graphics);
      table.Draw(page.Graphics);
    }

    public FileInfo GenerateTrophyReport() {
      return GenerateTrophyReport(-1);
    }

    public FileInfo GenerateTrophyReport(int trophyID) {
      FileInfo file = new FileInfo(Path.Combine(
        Path.GetTempPath(), string.Format("LDYC Trophy Report - {0:yyyy-MM-dd}.pdf", DateTime.Now)));

      using (FileStream fs = file.OpenWrite()) {
        GenerateTrophyReport(fs, trophyID);
      }

      return file;
    }

    public void GenerateTrophyReport(System.IO.Stream stream) {
      GenerateTrophyReport(stream, -1);
    }

    public void GenerateTrophyReport(System.IO.Stream stream, int trophyID) {
      // Raw data needed
      if (trophyID == -1) {
        tblTrophiesTableAdapter.Fill(Trophies);
        tblWinnersTableAdapter.Fill(Winners);

      } else {
        tblTrophiesTableAdapter.FillByTrophyID(Trophies, trophyID);
        tblWinnersTableAdapter.FillByTrophy(Winners, trophyID);
      }

      Document doc = CreateDocument();

      int pageNumber = 0;
      foreach (TrophyDataSet.tblTrophiesRow row in Trophies.Select("TRUE", "[fldName] ASC")) {
        AddTrophyPage(doc, row, ref pageNumber);
      }

      doc.Generate(stream);
    }

    public FileInfo GenerateWinnerReport(string sailNumber) {
      FileInfo file = new FileInfo(Path.Combine(
        Path.GetTempPath(), string.Format("Winner Report - {0} - {1:yyyy-MM-dd}.pdf", sailNumber, DateTime.Now)));

      using (FileStream fs = file.OpenWrite()) {
        GenerateWinnerReport(fs, sailNumber);
      }

      return file;
    }

    public void GenerateWinnerReport(System.IO.Stream stream, string sailNumber) {
      // Raw data needed
      TrophyDataSet.TrophyWinnersDataTable winners;
      using (TrophyDataSetTableAdapters.TrophyWinnersTableAdapter ad = new TrophyWinnersTableAdapter()) {
        winners = ad.GetData(sailNumber);
      }

      Document doc = CreateDocument();

      int pageNumber = 0;

      pageNumber++;
      Page page = new Page(A4Portrait.Width, A4Portrait.Height);
      doc.Pages.Content.Add(page);

      Siberix.PDF.Layout.Table.Table table;

      table = CreateTrophyWinnersTable(page, sailNumber, winners.Rows.Count);
      
      int rowIndex = 0;
      foreach (TrophyDataSet.TrophyWinnersRow winner in winners.Select("TRUE", "[fldYear] ASC, [fldTrophyName] ASC")) {
        AddTrophyWinnerRow(table, winner);

        /* Table needs to be measured, if it's too tall, then we need to remove this row,
         * draw it on the current page, add a new page, create a new table, and the row to it
         */
        table.Measure(page.Graphics);
        if ((table.Top + table.Height + Px(5)) > (page.Height - Margin)) {
          table.Rows.Remove(rowIndex, 0);

          // Draw the winners, and the footer, increment the page number
          table.Measure(page.Graphics);
          table.Draw(page.Graphics);
          DrawFooter(page, pageNumber);
          page.Graphics.Flush();
          pageNumber++;

          // New page
          page = new Page(A4Portrait.Width, A4Portrait.Height);
          doc.Pages.Content.Add(page);

          table = CreateTrophyWinnersTable(page, sailNumber, winners.Rows.Count);
          AddTrophyWinnerRow(table, winner);
          rowIndex = 0;
        }

        rowIndex++;
      }

      table.Measure(page.Graphics);
      table.Draw(page.Graphics);
      DrawFooter(page, pageNumber);
      page.Graphics.Flush();

      doc.Generate(stream);
    }

    private void Init() {
      // Classes need to be populated immediately
      ReloadClasses();
    }

    private float Px(float mm) {
      return mm * MM;
    }

    public void ReloadClasses() {
      using (tblClassesTableAdapter adapter = new tblClassesTableAdapter()) {
        adapter.Fill(Classes);
      }
    }
    #endregion
  }
}
