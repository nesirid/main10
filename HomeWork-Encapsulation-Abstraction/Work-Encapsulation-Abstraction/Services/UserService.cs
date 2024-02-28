using Homework_Encapsulation_Abstraction.Models;

namespace Homework_Encapsulation_Abstraction.Services
{
    internal class UserService
    {
        public User[] GetAll()
        {
            return new User[]
                    {
                         new User
                         {
                             id = 1,
                             fullName = "Fatime Qayxanova",
                             age = 22,
                             email = "fatime@code.edu.az",
                             password = "2312321321321",
                         },
                         new User
                         {
                             id = 2,
                             fullName = "Fexriyye Tagizade",
                             age = 21,
                             email = "fexriyye@code.edu.az",
                             password = "32312312321321",
                         },
                         new User
                         {
                             id = 3,
                             fullName = "Emiraslan Miriyev",
                             age = 33,
                             email = "Emiraslan@code.edu.az",
                             password = "1232312321312",
                         },
                    };

        }

        public User GetById(User[] users, int id)
        {
            return users.Where(m => m.id == id).FirstOrDefault();
        }
    }
}
