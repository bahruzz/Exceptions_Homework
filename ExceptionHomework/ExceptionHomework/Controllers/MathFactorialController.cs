using ExceptionHomework.Services;
using ExceptionHomework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomework.Controllers
{
    public class MathFactorialController
    {
        private readonly IFactorialService _factorialService;

        public MathFactorialController()
        {
            _factorialService=new FactorialService();
        }

        public void GetFactorial()
        {
            Console.WriteLine("Add number");
            int n=int.Parse(Console.ReadLine());

            Console.WriteLine(_factorialService.GetFactorial(n));
        }
    }
}
