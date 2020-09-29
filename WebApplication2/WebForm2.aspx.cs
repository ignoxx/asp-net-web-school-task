using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
		private double betrag;
		private double laufzeit;
		private double zinssatz;
		private double startjahr;
		protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				Single betrag = (Single)Session["BetragTxt"];
				Single zinssatz = (Single)Session["ZinssatzTxt"];
				Single startJahr = (Single)Session["StartjahrTxt"];
				Single laufzeit = (Single)Session["LaufzeitTxt"];

				this.betrag = betrag;
				this.laufzeit = laufzeit;
				this.zinssatz = zinssatz;
				this.startjahr = startJahr;

				generateTable();
			}
			catch (Exception) {
				Label1.Text = "Keine Daten für die Details vorhanden. Bitte füll das Formular aus";
				BtnRedirect.Visible = true;
			}
		}

		protected void BtnRedirect_Click(object sender, EventArgs e) => Response.Redirect("WebForm1.aspx");

		public void generateTable()
		{
			TableCell c1 = new TableHeaderCell();
			TableCell c2 = new TableHeaderCell();
			c1.Text = "Jahr";
			c2.Text = "Wert in Euro";

			TableRow r = new TableHeaderRow();
			r.Cells.Add(c1);
			r.Cells.Add(c2);
			r.BackColor = Color.DarkGray;

			Table1.Rows.Add(r);

			for (int i = 0; i < this.laufzeit; i++)
			{
				r = new TableRow();
				c1 = new TableCell();
				c2 = new TableCell();

				c1.Text = $"{this.startjahr + i}";
				c2.Text = $"{ZinsRechnung.ZinsesZins((float)this.betrag, (float)this.zinssatz, (float)i).ToString("C")}";

				r.Cells.Add(c1);
				r.Cells.Add(c2);
				Table1.Rows.Add(r);
			}
		}
	}
}