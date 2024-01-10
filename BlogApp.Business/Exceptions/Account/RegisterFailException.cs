using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Exceptions.Account
{
    public class RegisterFailException : Exception
    {
        public RegisterFailException() : base("Couldn't register!")
        {

        }
        public RegisterFailException(string message) : base(message)
        {
        }
    }
}