using WebApplication1.IRepositroy;

namespace WebApplication1.Repository
{
    public class LoginRepository:ILoginRepository
    {
        private readonly string _userRepository;
        public LoginRepository( string UserRepository)
        {
            _userRepository = UserRepository;
        }
    }
}
