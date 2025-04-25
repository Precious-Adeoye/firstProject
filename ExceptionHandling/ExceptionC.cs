using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ExceptionC : Exception
    {
        public ExceptionC(string message) : base(message)
        {

        }
      
    }
}
