using DAF_Holding_Task.Models;
using DAF_Holding_Task.ViewModels;

using Microsoft.EntityFrameworkCore;

namespace DAF_Holding_Task.Services
{
    public class PostService:IPostService
    {
        private readonly Context _context;

        public PostService(Context context)
        {
            _context = context;
        }
        public Post CreatePost(PostFormViewModel post)
        {
            Post NewPost = new Post()
            {
                Title = post.Title,
                Content = post.Content,
                DatePosted = post.DatePosted,
                UserProfileID = post.UserProfileID
            };
            _context.Add(NewPost);
            _context.SaveChanges();
            return NewPost;
        }
        
    }
}
