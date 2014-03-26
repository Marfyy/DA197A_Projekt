using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace Filmarkiv
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            

            //Movie[] foundMovies = SearchDatabase(txt_search.Text)
            //Response.Redirect("\Video.aspx?vName=" + movie.Name + "&vID=" + movie.ID);

            List<Movie> srcMovies = SearchForMovie(txt_search.Text);
            srcListRepeater.DataSource = srcMovies;
            srcListRepeater.DataBind();
        }  
        private List<Movie> SearchForMovie(string srcString)
        {
            List<Movie> output = new List<Movie>();
            XmlDocument xml = new XmlDocument();
            xml.Load(@"C:\git\DA197A_Projekt\Filmarkiv\Filmarkiv\movies.xml");

            XmlElement root = xml.DocumentElement;
            XmlNodeList subroot = root.SelectNodes("movie");

            for (int i = 0; i < subroot.Count; i++)
            {
                XmlNode elem = subroot.Item(i);
                if (elem.Attributes["title"].Value.Contains(srcString))
                {
                    Movie movie = new Movie();
                    movie.Name = elem.Attributes["title"].Value;
                    movie.ID = elem.Attributes["ID"].Value;
                    movie.Year = elem.Attributes["year"].Value;
                    movie.URL = elem.Attributes["link"].Value;
                    output.Add(movie);
                    //lbl_rating.Text = "IMDB Rating: " + elem.Attributes["imdbRating"].Value;
                }

            }

            return output;
        }
    }
    
}