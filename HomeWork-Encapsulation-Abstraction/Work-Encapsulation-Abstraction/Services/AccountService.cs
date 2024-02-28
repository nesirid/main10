
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Homework_Encapsulation_Abstraction.Services
{
    public class AccountService
    {
        private readonly UserService _userService;
        public AccountService()
        {
            _userService = new UserService();
        }
        
        public bool Login(string email, string password)
        {
        var users = _userService.GetAll();
            var user = users.FirstOrDefault(m => m.email == email && m.password == password);
            return user == null ? false : true;
        }
        

        
    }
}
