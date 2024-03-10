using ExceptionHomework.Helpers.Exceptions;
using ExceptionHomework.Models;
using ExceptionHomework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomework.Services
{
    public class UserService : IUserService
    {
        public string CheckEmailAndPassword(User[] users, string email, string password)
        {
            try
            {
                var result=users.FirstOrDefault(m=>m.Email == email && m.Password==password);
                if (result != null)
                {
                    return "Success";
                }
                else
                {
                    throw new CustomNullOrEmptyException("Data not found");
                }

            }
            catch (Exception msj)
            {

                return msj.Message;
            }
        }

        public User[] GetAll()
        {
            User user1 = new()
            {
                Id = 1,
                Name = "Rashad",
                Surname = "Aghayev",
                Age = 21,
                Email = "rashad@gmail.com",
                Password = "123456",
               

            };
            User user2 = new()
            {
                Id = 2,
                Name = "Qabil",
                Surname = "Memmedov",
                Age = 24,
                Email = "qabil@gmail.com",
                Password = "223456",


            };
            User user3 = new()
            {
                Id = 3,
                Name = "Habil",
                Surname = "Delisov",
                Age = 31,
                Email = "habil@gmail.com",
                Password = "323456",


            };
            User user4 = new()
            {
                Id = 4,
                Name = "Famil",
                Surname = "Ocaqov",
                Age = 61,
                Email = "ocaqov@gmail.com",
                Password = "523456",
                

            };
            return new User [] { user1, user2, user3,user4 };





        }

        public string Login(User[] users, string email, string password)
        {
            try
            {
                var result = users.FirstOrDefault(m => m.Email == email && m.Password==password);
                if (result != null)
                {
                    return "Success";
                }
                else (password.Length < 6).ToString();
                {
                    throw new CustomPasswordException("Password wrong ");
                }
                
            }
            catch (Exception letter)
            {

                return letter.Message;
            }
        }
    }
}
