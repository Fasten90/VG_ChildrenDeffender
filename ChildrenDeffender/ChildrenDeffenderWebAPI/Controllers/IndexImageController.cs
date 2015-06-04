using ChildrenDeffenderDatabaseModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

/*
namespace ChildrenDeffenderWebAPI.Controllers
{
    public class IndexImageController : ApiController
    {

        
        // GET: api/IndexImage
        [HttpGet]
        [Route("api/IndexImage", Name = "GetIndexImagesUrl")]
        public IHttpActionResult Get()
        {

            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                var items = new List<IndexImage>(context.IndexImage);
                if (items == null)
                {
                    return NotFound();
                }
                return Ok(items);
            }
        }



        // GET api/indeximage/5
        [HttpGet]
        [Route("api/IndexImage/{id}", Name = "GetIndexImageUrl")]
        public IHttpActionResult Get(int id)
        {
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                var item = context.IndexImage.SingleOrDefault(p => p.IndexImageID == id);
                if (item == null)
                {
                    return NotFound();
                }
                return Ok(item);
            }
        }


        // POST api/indeximage
        [HttpPost]
        [Route("api/IndexImage")]
        public IHttpActionResult Post([FromBody] IndexImage p)
        {
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                // TODO: maxID keresés ?????????????????????????????
                //p.MovieID = Movie.Max(i => i.MovieID) + 1;

                context.IndexImage.Add(p);
                context.SaveChanges();
                return Created(Url.Link("GetIndexImageUrl", new { id = p.IndexImageID.ToString() }), p);
            }
        }


        // PUT: api/IndexImage/5
        [HttpPut]
        [Route("api/IndexImage/UpdateIndexImage")]
        public IHttpActionResult Put([FromBody]IndexImage modifiedItem)
        {
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {

                context.IndexImage.Attach(modifiedItem);
                context.Entry(modifiedItem).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
        }
  

        [HttpDelete]
        [Route("api/IndexImage/{id}")]
        public IHttpActionResult Delete(int id)
        {
            using (ChildrenDeffenderEntities context = new ChildrenDeffenderEntities())
            {
                var item = context.IndexImage.SingleOrDefault(p => p.IndexImageID == id);
                if (item == null)
                {
                    return NotFound();
                }
                context.IndexImage.Remove(item);
                context.SaveChanges();
                return Ok();
            }
        }


    }
}


*/