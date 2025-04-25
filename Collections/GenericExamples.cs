using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericExamples<T>
    {
        public GenericExamples(T message)
        {
            Console.WriteLine(message);
        }
    }
}
