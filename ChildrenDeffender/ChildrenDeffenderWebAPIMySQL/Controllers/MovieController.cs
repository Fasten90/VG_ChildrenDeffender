using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChildrenDeffenderDatabaseModel;


namespace ChildrenDeffenderWebAPIMySQL.Controllers
{
    public class MovieController : ApiController
    {



        //
        /*
        // KISZEDNI, HA NEM FUT LE
        // több movie-hoz
        public IEnumerable<Movie> Get()
        {
            return GetMovies();
        }

        public static List<Movie> GetMovies()
        {
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                var movies = new List<Movie>(context.Movie);
                return movies;
            }
        }
        //*/

        ///*
        // 2015.05.05-én ez jó
        // GET: api/Movie
        [HttpGet]
        [Route("api/Movie", Name = "GetMoviesUrl")]
        public IHttpActionResult Get()
        {

            using (childrendeffenderEntities context = new childrendeffenderEntities())
            {
                var movies = new List<movie>(context.movie);
                if (movies == null)
                {
                    return NotFound();
                }
                return Ok(movies);
            }
        }
        //*/


        // web api 2 gyak doksi
        [HttpGet]
        [Route("api/Movie/{id}", Name = "GetMovieUrl")]
        public IHttpActionResult Get(int id)
        {
            using (childrendeffenderEntities context = new childrendeffenderEntities())
            {
                var movie = context.movie.SingleOrDefault(p => p.MovieID == id);
                if (movie == null)
                {
                    return NotFound();
                }
                return Ok(movie);
            }
        }


        [HttpPost]
        [Route("api/Movie")]
        public IHttpActionResult Post([FromBody] movie p)
        {
            using (childrendeffenderEntities context = new childrendeffenderEntities())
            {
                // TODO: maxID keresés ?????????????????????????????
                //p.MovieID = Movie.Max(i => i.MovieID) + 1;

                context.movie.Add(p);
                context.SaveChanges();
                return Created(Url.Link("GetMovieUrl", new { id = p.MovieID.ToString() }), p);
            }
        }


        // "updatelés"
        // TODO: eddig: [Route("api/Movie/{id}")] ez volt
        // PUT: api/Movie/5
        [HttpPut]
        [Route("api/Movie/UpdateMovie")]
        public IHttpActionResult Put([FromBody]movie modifiedMovie)
        {
            using (childrendeffenderEntities context = new childrendeffenderEntities()) // TODO: try-catch
            {

                context.movie.Attach(modifiedMovie);
                context.Entry(modifiedMovie).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
        }
        /*
        // DO NOT USE, from lab7
        // PUT: api/Product/5
		[HttpPut]
		[Route("api/Product/{id}")]
		public IHttpActionResult Put(int id, [FromBody]Product modifiedProduct)
        {
			try
			{
				ProductProvider.UpdateProduct(id, modifiedProduct);
				return Ok();
			}
			catch (ArgumentException)
			{
				return NotFound();
			}
        }*/



        [HttpDelete]
        [Route("api/Movie/{id}")]
        public IHttpActionResult Delete(int id)
        {
            using (childrendeffenderEntities context = new childrendeffenderEntities())
            {
                var movie = context.movie.SingleOrDefault(p => p.MovieID == id);
                if (movie == null)
                {
                    return NotFound();
                }
                context.movie.Remove(movie);
                context.SaveChanges();
                return Ok();
            }
        }




    }
}
