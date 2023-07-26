using WPFSql.DataAccess;

namespace WPFSql.Service
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id);
    }
}