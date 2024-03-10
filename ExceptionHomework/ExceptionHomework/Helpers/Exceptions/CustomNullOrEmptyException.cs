using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomework.Helpers.Exceptions
{
    internal class CustomNullOrEmptyException:Exception
    {
        public CustomNullOrEmptyException(string msj):base(msj) 
        {
            
        }
    }
}
