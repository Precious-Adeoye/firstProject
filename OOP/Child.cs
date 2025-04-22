using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Child
    {
        
        public string height;
        public int age;
        public Dad Dad;

        public Child( string height, int age, Dad dad)
        {
            this.height = height;
            this.age = age;
            this.Dad = dad;
        }

        public void Show() 
        {
            Console.WriteLine($"The father and the child bears same surname {Dad.surname} and  they share the same genotype which is {Dad.Genotype} and the child is {age} "); 
        }
    }
}
