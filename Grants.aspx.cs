using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Grants : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        CommunityAssistEntities entities = new CommunityAssistEntities();
       int pk = (int)Session["Person"];
        ServiceGrant g = new ServiceGrant();
        g.GrantAmount = Convert.ToDecimal(txtGrantAmount.Text);
        g.GrantNeedExplanation= txtGrantReason.Text;
        g.PersonKey = pk;

        entities.ServiceGrants.Add(g);
       
        entities.SaveChanges();
        Response.Redirect("TYGrant.aspx");
    }
}