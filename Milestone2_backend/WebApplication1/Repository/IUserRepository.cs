using WebApplication1.Modals;

namespace WebApplication1.Repository
{
    public interface IUserRepository
    {
        string Register(Users user);
        IEnumerable<Users> GetAll();
        string UpdateUser(Users user);
    }
}
