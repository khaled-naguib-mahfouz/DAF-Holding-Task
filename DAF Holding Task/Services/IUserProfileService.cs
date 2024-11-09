using DAF_Holding_Task.Models;
using DAF_Holding_Task.ViewModels;

namespace DAF_Holding_Task.Services
{
    public interface IUserProfileService
    {
        IEnumerable<UserProfile> GetAllUserProfiles();
        UserProfile GetUserProfileById(int id);
        UserProfile CreateUserProfile(UserProfileFormViewModel userProfile);
        UserProfile UpdateUserProfile(int id,UserProfileFormViewModel userProfile);
        bool DeleteUserProfile(int id);
        Task<IEnumerable<Post>> GetPostsByUserProfileIdAsync(int userProfileId);
    }
}
