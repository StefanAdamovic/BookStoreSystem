﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExceptionsBook
{
    class BookException : Exception
    {
        public BookException(string message) : base(message)
        {
        }
    }
}
