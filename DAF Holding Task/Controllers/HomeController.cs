using DAF_Holding_Task.Models;
using DAF_Holding_Task.ViewModels;
using DAF_Holding_Task.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DAF_Holding_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserProfileService _userProfileService;

        public HomeController(IUserProfileService userProfile)
        {
            _userProfileService = userProfile;
        }

        public IActionResult Index()
        {
            var AllUsers = _userProfileService.GetAllUserProfiles();
            return View(AllUsers);
        }
        public  IActionResult Details(int id)
        {
            var user = _userProfileService.GetUserProfileById(id);
            return View(user);
        }
        public IActionResult Delete(int id)
        {
            _userProfileService.DeleteUserProfile(id);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            UserProfileFormViewModel User = new();

            return View(User);
        }
        [HttpPost]
        public IActionResult Create(UserProfileFormViewModel user)
        {
            if(ModelState.IsValid)
            {
                _userProfileService.CreateUserProfile(user);
                return RedirectToAction("index");
            }
            else
            {
                return View(user);
            }
        }
        public IActionResult Edit(int id)
        {
            var userProfileToEdit = _userProfileService.GetUserProfileById(id);
           
            var viewModel = new UserProfileFormViewModel
            {
                Id = userProfileToEdit.Id,
                FirstName = userProfileToEdit.FirstName,
                LastName = userProfileToEdit.LastName,
                Email = userProfileToEdit.Email,
                DateOfBirth = userProfileToEdit.DateOfBirth
            };
            return View("Create",viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, UserProfileFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var updatedUser =  _userProfileService.UpdateUserProfile(id, viewModel);

            if (updatedUser == null)
            {
                return NotFound();
            }

            return RedirectToAction("index");
        }
    }
}
