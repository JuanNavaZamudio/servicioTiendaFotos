using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Linq;

namespace service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StorePost> Get()
        {
            List<StorePost> posts = new List<StorePost>();

            using (var db = new PostContext())
            {
                posts = db.Posts.
                            OrderBy(p => p.id).
                            ToList<StorePost>();
            }

            return posts;
        }

        [HttpPost]
        [Route("NewPostList")]
        public Response NewPostList(List<StorePost> posts)
        {
            Response response = new Response();
            using (var db = new PostContext())
            {
                foreach (StorePost post in posts)
                {
                    db.Add(post);
                    db.SaveChanges();
                }

                response.State = 0;
                response.Message = "posts saved succesfully";
            }
            return response;
        }

        [HttpPost]
        [Route("NewPost")]
        public Response NewPost(StorePost post)
        {
            Response response = new Response();
            using (var db = new PostContext())
            {
                db.Add(post);
                db.SaveChanges();

                response.State = 0;
                response.Message = "post saved succesfully";
            }
            return response;
        }
    }
}
