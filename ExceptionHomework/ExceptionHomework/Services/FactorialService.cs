using ExceptionHomework.Helpers.Exceptions;
using ExceptionHomework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomework.Services
{
    public class FactorialService : IFactorialService

    {
        public string GetFactorial(int? n)
        {
            int result = 1;
            try
            {
                if (n == 0)
                {
                    result = 1;
                    
                }
                else if (n < 0)
                {
                    throw new CustomNegativeNumber("Factorial menfi eded ola bilemz");

                }
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result.ToString();   

            }
            catch (Exception msj)
            {

                return  msj.Message;
            }
            
        }
    }
}
