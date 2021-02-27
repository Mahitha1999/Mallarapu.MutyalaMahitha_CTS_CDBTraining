using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCruiser.Utility;
using Com.Cognizant.MovieCruiser.Model;

namespace Com.Cognizant.MovieCruiser.Dao
{

    public class MovieDaoCollection : IMovieDao
    {
        public static List<Movie> movieList = null;
        static public void MovieListInitialization()
        {
            if (movieList == null)
            {
                movieList = new List<Movie>()
        {

             new Movie() { Id=1, Title="Avatar",BoxOffice="$2,787,965,087",
             Active=true,DateOfLaunch=DateUtility.ConvertToDate("15/03/2017"),
                 Genre="Science Fiction", HasTeaser=true},
              new Movie() { Id=2, Title="The Avengers",BoxOffice="$1,518,812,988",
             Active=true, DateOfLaunch = DateUtility.ConvertToDate("23/12/2017"),
                 Genre="Superhero", HasTeaser=false},
               new Movie() { Id=3, Title="Titanic",BoxOffice="$2,187,463,944",
             Active=true, DateOfLaunch = DateUtility.ConvertToDate("21/08/2017"),
                 Genre="Romance", HasTeaser=false},
                new Movie() { Id=4, Title="Jurassic World" , BoxOffice="$1,617,713,208",
             Active=false, DateOfLaunch = DateUtility.ConvertToDate("02/07/2017"),
                 Genre="Science Fiction", HasTeaser=true},
              new Movie() { Id=5, Title="Avengers" , BoxOffice="$2,750,760,348",
             Active=true, DateOfLaunch = DateUtility.ConvertToDate("02/11/2022"),
                 Genre="Superhero", HasTeaser=true},

        };
            }
        }
        public Movie GetMovie(int MovieId)
        {
            Movie m = new Movie();
            foreach (Movie movie in movieList)
            {
                if (MovieId == movie.Id)
                    m = movie;

            }
            return m;
        }

        public List<Movie> GetMovieListAdmin()
        {
            return movieList;
        }

        public List<Movie> GetMovieListCustomer()
        {
            return movieList;
        }

        public void ModifyMovie(Movie movie)
        {
            foreach (Movie m in movieList)
            {
                if (m == movie)
                {
                    Console.WriteLine("Enter The Title you want to edit");
                    m.Title = Console.ReadLine();
                    Console.WriteLine("Enter Boxoffice");
                    m.BoxOffice = Console.ReadLine();
                    Console.WriteLine("Enter Active");
                    m.Active = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Enter Dateoflaunch");
                    m.DateOfLaunch = DateUtility.ConvertToDate(Console.ReadLine());
                    Console.WriteLine("Enter genre");
                    m.Genre = Console.ReadLine();
                    Console.WriteLine("Enter Hasteaser");
                    m.HasTeaser = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Selected Record Updated Succesfully");
                }
            }
        }
    }
   
    public class FavoritesDaoCollection : IFavoritesDao
    {
        public static List<Movie> favoritesMovieList = null;

        public static void FavoritesListInitialization()
        {
            if (favoritesMovieList == null)
            {
                favoritesMovieList = new List<Movie>()
                {

                    new Movie()
                    {
                        Id = 1,
                        Title = "Avatar",
                        BoxOffice = "$2787965087",
                        Active = true,
                        DateOfLaunch = DateUtility.ConvertToDate("15/03/2017"),
                        Genre = "Science Fiction",
                        HasTeaser = true
                    },

                    new Movie()
                    {
                        Id = 2,
                        Title = "The Avengers",
                        BoxOffice = "$1518812988",
                        Active = true,
                        DateOfLaunch = DateUtility.ConvertToDate("23/12/2017"),
                        Genre = "Superhero",
                        HasTeaser = false
                    },

                    new Movie()
                    {
                        Id = 3,
                        Title = "Titanic",
                        BoxOffice = "$2187463944",
                        Active = true,
                        DateOfLaunch = DateUtility.ConvertToDate("21/08/2017"),
                        Genre = "Romance",
                        HasTeaser = false
                    }
                };
            }
        }
        public void AddMovieToFavorites(long userId, long movieId)
        {
            MovieDaoCollection movieDao = new MovieDaoCollection();
            List<Movie> movieList = movieDao.GetMovieListCustomer();
            Movie movie = (from temp in movieList
                           where temp.Id == movieId
                           select temp).FirstOrDefault();
            if (!favoritesMovieList.Contains(movie))
            {
                if (movie != null)
                {
                    int id = favoritesMovieList.Count() - 1;
                    favoritesMovieList.Insert(id, movie);
                    Console.WriteLine("Movie is added to favorites successfully");
                }
            }
            else
                Console.WriteLine("Movie is already in favorites");

           
        }
        public void GetAllMoviesFromFavorites(long userId)
        {
            Console.WriteLine("Favorites:");
            Console.WriteLine("ID  Title               Box Office($)    Genre");
            for (int i = 0; i < favoritesMovieList.Count(); i++)
            {
                Console.WriteLine("{0}   {1,-18}  {2,-13}    {3}", favoritesMovieList[i].Id, favoritesMovieList[i].Title, favoritesMovieList[i].BoxOffice, favoritesMovieList[i].Genre);
            }
            Console.WriteLine("No. of Favorites: " + favoritesMovieList.Count());
        }
        public void RemoveMovieFromFavorites(long userId, long movieId)
        {
            foreach (Movie movie in favoritesMovieList)
            {
                if (movie.Id == movieId)
                {
                    int i = (int)movieId - 1;
                    favoritesMovieList.Remove(favoritesMovieList[i]);
                   
                }
            }
        }
       
    }
}

public interface IMovieDao
    {
    }
