using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
		protected void Button1_Click(object sender, EventArgs e) => zinsBerechnen(sender);

		private void zinsBerechnen(object sender)
		{
			double betrag, zinssatz, startJahr, laufZeit;
			bool failed = false;

			if (!double.TryParse(BetragTxt.Text, out betrag))
				failed = true;

			if (!double.TryParse(ZinssatzTxt.Text, out zinssatz))
				failed = true;

			if (!double.TryParse(StartjahrTxt.Text, out startJahr))
				failed = true;

			if (!double.TryParse(LaufzeitTxt.Text, out laufZeit))
				failed = true;

			if (failed)
			{
				ErgebnisLbl.Text = "Ungültige eingabe!";
				return;
			}

			ErgebnisLbl.Text = ZinsRechnung.ZinsesZins((float)betrag, (float)zinssatz, (float)laufZeit).ToString("C");
			BtnDetails.Visible = true;

			// Save data in session
			Session["BetragTxt"] = Convert.ToSingle(BetragTxt.Text);
			Session["ZinssatzTxt"] = Convert.ToSingle(ZinssatzTxt.Text);
			Session["StartjahrTxt"] = Convert.ToSingle(StartjahrTxt.Text);
			Session["LaufzeitTxt"] = Convert.ToSingle(LaufzeitTxt.Text);
		}

		protected void ZinssatzTxt_TextChanged(object sender, EventArgs e) => zinsBerechnen(sender);
		protected void LaufzeitTxt_TextChanged(object sender, EventArgs e) => zinsBerechnen(sender);
		protected void BetragTxt_TextChanged(object sender, EventArgs e) => zinsBerechnen(sender);
		protected void BtnDetails_Click(object sender, EventArgs e) => Response.Redirect("WebForm2.aspx");
	}
}