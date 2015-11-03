using NewsProject.Models;
using NewsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace NewsProject.API
{
    public class CommentsController : ApiController
    {
        private ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            this._commentService = commentService;
        }

        //public IHttpActionResult Get(int id)
        //{
        //    var comment = _commentService.GetComment(id);
          
        //    return Ok(comment);

        //}

        public IHttpActionResult Post(Comment comment)
        {
            comment.UserId = this.User.Identity.GetUserId();
            _commentService.AddComment(comment);
            return Ok(comment);
        }
    }
}
