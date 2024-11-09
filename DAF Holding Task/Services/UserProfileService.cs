using DAF_Holding_Task.Models;
using DAF_Holding_Task.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DAF_Holding_Task.Services
{
    public class UserProfileService:IUserProfileService
    {
        private readonly Context _context;

        public UserProfileService(Context context)
        {
            _context = context;
        }

        public IEnumerable<UserProfile> GetAllUserProfiles()
        {
            return  _context.userProfiles.Include(u => u.posts).ToList();
        }

        public  UserProfile GetUserProfileById(int id)
        {
            return _context.userProfiles.Include(u => u.posts).FirstOrDefault(u => u.Id == id);
        }

        public UserProfile CreateUserProfile(UserProfileFormViewModel userProfile)
        {
            UserProfile user = new()
            {
                FirstName = userProfile.FirstName,
                LastName = userProfile.LastName,
                Email = userProfile.Email,
                DateOfBirth = userProfile.DateOfBirth
            };
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }

        public UserProfile UpdateUserProfile(int id,UserProfileFormViewModel userProfile)
        {
            var UserToEdit = _context.userProfiles.FirstOrDefault(u => u.Id == id);
            if (UserToEdit == null)
            {
                return null;
            }
            UserToEdit.FirstName = userProfile.FirstName;
            UserToEdit.LastName = userProfile.LastName;
            UserToEdit.Email= userProfile.Email;
            UserToEdit.DateOfBirth = userProfile.DateOfBirth;
            _context.SaveChanges();
            return UserToEdit;
        }

        public  bool DeleteUserProfile(int id)
        {
            
            var userProfile = _context.userProfiles.Find(id);
            if (userProfile == null)
                return false;
            _context.userProfiles.Remove(userProfile);
            _context.SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Post>> GetPostsByUserProfileIdAsync(int userProfileId)
        {
            return await _context.posts
                .Where(p => p.UserProfileID == userProfileId)
                .ToListAsync();
        }
    }
}
