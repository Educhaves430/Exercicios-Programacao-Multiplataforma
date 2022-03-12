using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp7
{
    public class InvalidLineException : System.ApplicationException
    {
        public InvalidLineException(string msg) : base(msg)
        {
        }
    }
}
