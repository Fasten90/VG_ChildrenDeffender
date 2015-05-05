using ChildrenDeffenderWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChildrenDeffenderWebAPI.Controllers
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

            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                var movies = new List<Movie> (context.Movie);
                //movies = ;
                if (movies == null)
                {
                    return NotFound();
                }
                return Ok(movies);
            }
        }
        //*/


        // GET api/movie
        /* // Generált
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        */


        // web api 2 gyak doksi
        [HttpGet]
        [Route("api/Movie/{id}", Name = "GetMovieUrl")]
        public IHttpActionResult Get(int id)
        {
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                var movie = context.Movie.SingleOrDefault(p => p.MovieID == id);
                if (movie == null)
                {
                    return NotFound();
                }
                return Ok(movie);
            }
        }


        [HttpPost]
        [Route( "api/Movie" )]
        public IHttpActionResult Post( [FromBody] Movie p )
        {
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                // TODO: maxID keresés ?????????????????????????????
                //p.MovieID = Movie.Max(i => i.MovieID) + 1;

                context.Movie.Add( p );
                context.SaveChanges();
                return Created( Url.Link( "GetMovieUrl", new { id = p.MovieID.ToString() } ), p );
            }
        }


        // "updatelés"
        // TODO: eddig: [Route("api/Movie/{id}")] ez volt
        // PUT: api/Movie/5
        [HttpPut]
        [Route("api/Movie/UpdateMovie")]
        public IHttpActionResult Put([FromBody]Movie modifiedMovie)
        {
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {

                context.Movie.Attach(modifiedMovie);
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
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                var movie = context.Movie.SingleOrDefault(p => p.MovieID == id);
                if (movie == null)
                {
                    return NotFound();
                }
                context.Movie.Remove(movie);
                context.SaveChanges();
                return Ok();
            }
        }


                /*
        // GET api/movie/5
        public string Get(int id)
        {
            return "value";
        }
        */

        /*
        // POST api/movie
        public void Post([FromBody]string value)
        {
        }

        // PUT api/movie/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/movie/5
        public void Delete(int id)
        {
        }
        */
    }
}
