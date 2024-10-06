using WebApplication1.DTO.Request;
using WebApplication1.DTO.Response;

namespace WebApplication1.Service
{
    public interface IUserService
    {
        string Register(UserRequest user);
        IEnumerable<UsersResponse> GetAllUser();
        string UpdateUser(UserRequest user, Guid id);
    }
}
