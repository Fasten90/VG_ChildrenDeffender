using ChildrenDeffenderWebAPI.Models;
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

            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                var items = new List<User>(context.User); // TODO: ITT EXCEPTION VAN, HA NINCS SZERVER
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
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                var item = context.User.SingleOrDefault(p => p.UserID == id);
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
        public IHttpActionResult Post([FromBody] User p)
        {
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                // TODO: maxID keresés ?????????????????????????????
                //p.MovieID = Movie.Max(i => i.MovieID) + 1;

                context.User.Add(p);
                context.SaveChanges();
                return Created(Url.Link("GetUserUrl", new { id = p.UserID.ToString() }), p);
            }
        }


        // PUT: api/User/5
        [HttpPut]
        [Route("api/User/UpdateUser")]
        public IHttpActionResult Put([FromBody]User modifiedItem)
        {
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {

                context.User.Attach(modifiedItem);
                context.Entry(modifiedItem).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
        }
  

        [HttpDelete]
        [Route("api/User/{id}")]
        public IHttpActionResult Delete(int id)
        {
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                var item = context.User.SingleOrDefault(p => p.UserID == id);
                if (item == null)
                {
                    return NotFound();
                }
                context.User.Remove(item);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
