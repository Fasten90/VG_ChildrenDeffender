using ChildrenDeffenderDatabaseModel;
using System.Collections.Generic;
using System.Web.Http;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;

namespace ChildrenDeffenderWebAPI.Controllers
{
    public class UserController : ApiController
    {
    
        // GET: api/User
        [HttpGet]
        [Route("api/User", Name = "GetUsersUrl")]
        public IHttpActionResult Get()
        {

            using (childrendeffenderEntities context = new childrendeffenderEntities())
            {
                var items = new List<user>(context.user); // TODO: ITT EXCEPTION VAN, HA NINCS SZERVER
                if (items == null)
                {
                    return NotFound();
                }
                return Ok(items);
            }
        }



        // GET api/User/5
        [HttpGet]
        [Route("api/User/{id}", Name = "GetUserUrl")]
        public IHttpActionResult Get(int id)
        {
            using (childrendeffenderEntities context = new childrendeffenderEntities())
            {
                var item = context.user.SingleOrDefault(p => p.UserID == id);
                if (item == null)
                {
                    return NotFound();
                }
                return Ok(item);
            }
        }


        // POST api/User
        [HttpPost]
        [Route("api/User")]
        public IHttpActionResult Post([FromBody] user p)
        {
            using (childrendeffenderEntities context = new childrendeffenderEntities())
            {
                // TODO: maxID keresés ?????????????????????????????
                //p.MovieID = Movie.Max(i => i.MovieID) + 1;

                context.user.Add(p);
                context.SaveChanges();
                return Created(Url.Link("GetUserUrl", new { id = p.UserID.ToString() }), p);
            }
        }


        // PUT: api/User/5
        [HttpPut]
        [Route("api/User/UpdateUser")]
        public IHttpActionResult Put([FromBody]user modifiedItem)
        {
            using (childrendeffenderEntities context = new childrendeffenderEntities())
            {

                context.user.Attach(modifiedItem);
                context.Entry(modifiedItem).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
        }
  

        [HttpDelete]
        [Route("api/User/{id}")]
        public IHttpActionResult Delete(int id)
        {
            using (childrendeffenderEntities context = new childrendeffenderEntities())
            {
                var item = context.user.SingleOrDefault(p => p.UserID == id);
                if (item == null)
                {
                    return NotFound();
                }
                context.user.Remove(item);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
