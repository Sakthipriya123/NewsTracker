using NewsProject.Models;

namespace NewsProject.Services
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
    }
}