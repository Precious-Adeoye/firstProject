using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public class Dad
    {
        public string surname;
        public string name;
        public string Genotype;
        public int Age;

        public Dad(string surname, string genotype, int age, string name)
        {
            this.surname = surname;
            Genotype = genotype;
            Age = age;
            this.name = name;
        }




    }
}
