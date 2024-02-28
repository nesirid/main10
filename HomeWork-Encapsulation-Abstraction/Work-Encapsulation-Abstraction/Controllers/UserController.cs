using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_Encapsulation_Abstraction.Helpers.Constants;
using Homework_Encapsulation_Abstraction.Services;

namespace Homework_Encapsulation_Abstraction.Controllers
{
    internal class UserController
    {
        private readonly UserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }
        public void GetAll()
        { 
        var users = _userService.GetAll();
            foreach (var user in users) 
            {
                string result = $"{user.fullName} - {user.age} - {user.email}";
                Console.WriteLine(result);
            }
        }
        public void GetById()
        {
            Console.WriteLine("Enter user id ");
            UserNotFound:
            UserId:  string strId = Console.ReadLine();

            int id;

            bool isCorrectId = int.TryParse(strId, out id);
            if (isCorrectId)

            {
                var user = _userService.GetById(_userService.GetAll(), id);
                if (user == null)
                {
                    Console.WriteLine(ResponseMessages.NotFound);
                
                goto UserNotFound;

                }
                string result = $"{user.fullName} - {user.age} - {user.email}";
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine(ResponseMessages.IncorrectNumberFormat);
                goto UserId;
            }



        }
    }
}
