using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Application.Posts;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PostsController : ControllerBase
    {

        private readonly IMediator mediator;

        private readonly DataContext context;

        

        public PostsController(IMediator mediator, DataContext context) {
            this.mediator = mediator;
            this.context = context;
        }
        public async Task<ActionResult<List<Post>>> List() 
        {
            return this.context.Posts.ToList();
        }

        [HttpGet]

        public ActionResult<Post> GetById(Guid id)
        {
            return this.context.Posts.Find(id);
        }
    }
}