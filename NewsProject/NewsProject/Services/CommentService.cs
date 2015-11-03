using CoderCamps;
using Microsoft.AspNet.Identity;
using NewsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsProject.Services
{
    public class CommentService : ICommentService
    {
        private IGenericRepository _repo;

        public CommentService(IGenericRepository repo)
        {
            this._repo = repo;
        }

        public object User { get; private set; }

        public void AddComment(Comment comment)
        {
            
            comment.CommentedOn = DateTime.Now;
            this._repo.Add(comment);
            this._repo.SaveChanges();
        }

       
    }
}