using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // Movies/Index
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //There are 3 ways to pass data to a view

            //ViewData method:
            //ViewData["Movie"] = movie;

            //ViewBag method:
            //ViewBag.Movie = movie;

            //Both viewBag and viewData need their own methods of being called in the HTML view. 
            //This is more effort than just using standard objects and provides no real benefit


            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model


            //This is the last method, doing it via normal object passing
            return View(viewModel);

            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });

        }

        //This is the definition of the custom routing made with attributes instead of manual string-based definition
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }


        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}