using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NAVReaderWebApp.NAV
{
    public partial class IndexForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NAVI nav = new NAVI(new Uri("http://localhost:7048/DynamicsNAV100/ODataV4/Company('CRONUS%20CZ%20s.r.o.')"));
            nav.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;

            var customers = nav.Customer.Select(c => new { c.Name, c.No });
            var customersCount = nav.Customer.Count();

            TextBoxCount.Text = customersCount.ToString();
            GridViewCust.DataSource = customers;
            GridViewCust.DataBind();
        }
    }
}