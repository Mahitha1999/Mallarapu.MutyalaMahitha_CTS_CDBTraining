using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.Cognizant.MovieCruiser.Model;
using Com.Cognizant.MovieCruiser.Utility;
using Com.Cognizant.MovieCruiser.Dao;

namespace MovieCruiser
{
    public partial class MovieListAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MovieDaoCollection MovieDaoCollections = new MovieDaoCollection();
            MovieDaoCollection.MovieListInitialization();
            GridView1.DataSource = MovieDaoCollection.movieList;
            GridView1.DataBind();
        }

      

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}