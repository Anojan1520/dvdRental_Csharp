using WebApplication1.Modals;

namespace WebApplication1.IRepositroy
{
    public interface IUserRepository
    {
        string Register(Users user);
        IEnumerable<Users> GetAll();
        string UpdateUser(Users user);
        string DeleteUser(Guid userid);
    }
}
