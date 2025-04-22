using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    public class ClassObject
    {
        public int accno;
        public string name;
        public static float  rateOfIntrest;
        public ClassObject(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
           
        }

        static ClassObject()
        {
            rateOfIntrest = 8.8f;
        }

        public void display()
        { Console.WriteLine(accno + " " + name + rateOfIntrest); }
    


        /*
        public int id;
        public string name;
        public float salary;

        // Constructor with parameters
        public ClassObject(int i, string n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }

        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
        // Constructor without parameters
        public ClassObject()
        {
            Console.WriteLine("default constructor invoked");
        }
        */
        //public int id;
        //public string name;

        //public void insert (int i, string n)
        //{
        //    id = i;
        //    name = n;
        //}

        //public void display()
        //{
        //    Console.WriteLine("Id: " + id);
        //    Console.WriteLine("Name: " + name);
        //}

}
}
