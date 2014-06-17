using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Donations : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDonateMore_Click(object sender, EventArgs e)
    {
        CommunityAssistEntities entities = new CommunityAssistEntities();
        int pk = (int)Session["Person"];
        Donation d = new Donation();
        d.DonationAmount = Convert.ToDecimal(txtDonate.Text);
             
        d.DonationAmount = pk;

        entities.Donations.Add(d);

        //entities.SaveChanges();
        Response.Redirect("TYDonation.aspx");
    }
}