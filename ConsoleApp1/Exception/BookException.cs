using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception
{
    class BookException : ApplicationException
    {
        public BookException(string message) : base(message)
        {
        }
    }
}
