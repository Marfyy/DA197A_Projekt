using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Filmarkiv
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            string src = txt_search.Text;
            string apirequest = "http://omdbapi.com/?r=XML&t=" + src;
            WebClient client = new WebClient();
            string xmldoc = client.DownloadString(apirequest);
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmldoc);


            XmlElement root = xml.DocumentElement;
            XmlNodeList subroot = root.SelectNodes("movie");

            for (int i = 0; i < subroot.Count; i++)
            {

                XmlNode elem = subroot.Item(i);
                lbl_title.Text = "Title: " + elem.Attributes["title"].Value;
                lbl_year.Text = "Year: " + elem.Attributes["year"].Value;
                lbl_rated.Text = "Rated: " + elem.Attributes["rated"].Value;
                lbl_released.Text = "Released: " + elem.Attributes["released"].Value;
                lbl_runtime.Text = "Runtime: " + elem.Attributes["runtime"].Value;
                lbl_genre.Text = "Genre: " + elem.Attributes["genre"].Value;
                lbl_director.Text = "Director: " + elem.Attributes["director"].Value;
                lbl_writer.Text = "Writer: " + elem.Attributes["writer"].Value;
                lbl_actors.Text = "Actors: " + elem.Attributes["actors"].Value;
                lbl_plot.Text = "Plot: " + elem.Attributes["plot"].Value;
                lbl_language.Text = "Language: " + elem.Attributes["language"].Value;
                lbl_country.Text = "Country: " + elem.Attributes["country"].Value;
                lbl_awards.Text = "Awards: " + elem.Attributes["awards"].Value;
                lbl_metascore.Text = "Metascore: " + elem.Attributes["metascore"].Value;
                lbl_rating.Text = "IMDB Rating: " + elem.Attributes["imdbRating"].Value;
                
            }
            
        }

        
        
    }
}