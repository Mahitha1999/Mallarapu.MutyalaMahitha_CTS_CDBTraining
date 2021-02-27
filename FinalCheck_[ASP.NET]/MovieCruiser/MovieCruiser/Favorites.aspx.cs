using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.Cognizant.MovieCruiser.Dao;
using Com.Cognizant.MovieCruiser.Model;

namespace MovieCruiser
{
    public partial class Favorites : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FavoritesDaoCollection favoritesDao = new FavoritesDaoCollection();
            FavoritesDaoCollection.FavoritesListInitialization();
            GridView1.DataSource = FavoritesDaoCollection.favoritesMovieList;
            GridView1.DataBind();
            NoOfFavorites.Text = FavoritesDaoCollection.favoritesMovieList.Count().ToString();

            if (Request.QueryString["id"] != null)
            {
                FavoritesDaoCollection.FavoritesListInitialization();
                int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                Movie obj = (from x in FavoritesDaoCollection.favoritesMovieList
                             where x.Id == id
                             select x).FirstOrDefault();
                if (obj != null)
                {
                    if (FavoritesDaoCollection.favoritesMovieList.Contains(obj))
                    {
                        FavoritesDaoCollection.favoritesMovieList.Remove(obj);
                        GridView1.DataSource = FavoritesDaoCollection.favoritesMovieList;
                        GridView1.DataBind();
                        NoOfFavorites.Text = FavoritesDaoCollection.favoritesMovieList.Count().ToString();
                     
                    }
                    Boolean ShowPanel = Convert.ToBoolean(Request.QueryString["ShowPanel"].ToString());
                    if (ShowPanel)
                    {
                        notification.Visible = true;
                    }

                }
                else
                {
                    Console.WriteLine("FavoritesEmpty.aspx");
                }
               
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
    }
}