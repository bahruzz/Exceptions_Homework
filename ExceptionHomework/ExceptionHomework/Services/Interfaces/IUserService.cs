using ExceptionHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomework.Services.Interfaces
{
 public interface IUserService

    {
        User[] GetAll();
        public string CheckEmailAndPassword(User[] users, string email, string password);

        public string Login(User[] users, string email, string password);
    }

}
