using DAF_Holding_Task.Models;
using DAF_Holding_Task.ViewModels;

namespace DAF_Holding_Task.Services
{
    public interface IPostService
    { 
        Post CreatePost(PostFormViewModel post); 
    }
}
