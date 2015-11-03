using CoderCamps;
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

        public void AddComment(Comment comment)
        {
            comment.CommentedOn = DateTime.Now;
            comment.User = comment.User;
            this._repo.Add(comment);
            this._repo.SaveChanges();
        }

        }
}