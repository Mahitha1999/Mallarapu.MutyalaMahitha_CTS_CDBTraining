using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.Cognizant.MovieCruiser.Model;
using Com.Cognizant.MovieCruiser.Dao;
using Com.Cognizant.MovieCruiser.Utility;

namespace MovieCruiser
{
    public partial class EditMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                   
                    MovieDaoCollection.MovieListInitialization();
                    int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                    Movie obj = (from x in MovieDaoCollection.movieList
                                 where x.Id == id
                                 select x).FirstOrDefault();
                    if (obj != null)
                    {
                        TxtTitle.Text = obj.Title;
                        TxtGross.Text = obj.BoxOffice.ToString();
                        if (obj.Active)
                        {
                            Yes.Checked = true;
                        }
                        else
                        {
                            No.Checked = true;
                        }
                        TxtDate.Text = obj.DateOfLaunch.ToString();
                        Genre.SelectedValue = obj.Genre;
                        if (obj.HasTeaser)
                        {
                            HasTeaser.Checked = true;
                        }
                        else
                        {
                            HasTeaser.Checked = false;
                        }



                    }


                }
            }
        }
    

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Com.Cognizant.MovieCruiser.Dao.MovieDaoCollection movieDaoCollection = new MovieDaoCollection();
            MovieDaoCollection.MovieListInitialization();
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            //Movie obj = (from x in movieDao.movieList
            //             where x.Id == id
            //             select x).FirstOrDefault();
            Boolean active;
            Boolean hasTeaser;
            if (Yes.Text == "Yes")
            {
                active = true;
            }
            else
            {
                active = false;
            }

            if (HasTeaser.Checked)
            {
                hasTeaser = true;
            }
            else
            {
                hasTeaser = false;
            }
            MovieDaoCollection.movieList.Where(w => w.Id == id).ToList().ForEach(i =>
            {
                i.Title = TxtTitle.Text;
                i.BoxOffice = TxtGross.Text;
                i.Active = active;
                i.DateOfLaunch = DateUtility.ConvertToDate(TxtDate.Text);
                i.Genre = Genre.SelectedValue;
                i.HasTeaser = hasTeaser;
            });

            Response.Redirect("EditMovieStatus.aspx");
        }
            
        
    }
}

