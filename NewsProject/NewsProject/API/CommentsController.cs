using NewsProject.Models;
using NewsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsProject.API
{
    public class CommentsController : ApiController
    {
        private ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            this._commentService = commentService;
        }

        public IHttpActionResult Post(Comment comment)
        {
            _commentService.AddComment(comment);
            return Ok(comment);
        }
    }
}
