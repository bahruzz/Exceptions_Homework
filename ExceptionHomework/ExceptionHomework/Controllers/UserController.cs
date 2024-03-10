using ExceptionHomework.Services;
using ExceptionHomework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomework.Controllers
{
  public class UserController
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService=new UserService();

        
        }

        public void GetAll()
        {
            var users = _userService.GetAll();
            foreach (var user in users)
            {
                string result = $"{user.Name} {user.Surname} {user.Age} {user.Email} {user.Password} ";
                Console.WriteLine(result);
            } 

        }

        public void CheckEmailOrPassword()
        {
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            var result = _userService.CheckEmailAndPassword(_userService.GetAll(), email, password);
            Console.WriteLine(result);
        }


        public void Login()
        {
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            var result = _userService.Login(_userService.GetAll(), email, password);
            Console.WriteLine(result);
        }
    }

}
