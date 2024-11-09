using DAF_Holding_Task.Models;
using DAF_Holding_Task.Services;
using DAF_Holding_Task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DAF_Holding_Task.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IUserProfileService _userProfileService;
        public PostController(IPostService postService, IUserProfileService userProfileService)
        {
            _postService = postService;
            _userProfileService = userProfileService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            var userProfiles = _userProfileService.GetAllUserProfiles();
            var userProfileOptions = userProfiles.Select(u => new
            {
                u.Id,
                FullName = $"{u.FirstName} {u.LastName}"
            });

            PostFormViewModel post = new PostFormViewModel()
            {
                UserProfiles = new SelectList(userProfileOptions, "Id", "FullName")
            };
            return View(post);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PostFormViewModel postFormViewModel)
        {
            
                _postService.CreatePost(postFormViewModel);
                return RedirectToAction("Index", "Home");
        }

    }
}
