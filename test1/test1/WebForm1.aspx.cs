using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace test1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string src = txtbox1.Text;
            string apirequest = "http://omdbapi.com/?r=XML&t=" + src;
            WebClient client = new WebClient();
            txtbox2.Text = client.DownloadString(apirequest);
        }
    }
}