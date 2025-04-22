using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    public class Functions
    {
        public void Show()
        {
            Console.WriteLine("This is not a parameterized function");
        }

        public void Show (string message)
        {
            Console.WriteLine("This is a parameterized function " + message);
        }

        public void show(int val)
        {
            val *= val;

            Console.WriteLine("value after calling the function" +  val);
        } 

        public  void Show(ref int val)
        {
            val *= val;
            Console.WriteLine("value inside the function" + val);
        }

        public void flow(out int val)
        {
            int squre = 5;
            val = squre;
            val*= val;
            Console.WriteLine("value inside the function" + val);
        }
    }

    public static class  Sclass
    {
        public static float pi = 3.14f;
        public static int cube  (int n){ return n * n * n; }
    }

    public struct Example
    {
        public int width, height;
        public Example(int w, int h)
        {
            width = w;
            height = h;
        }

        public void show()
        {
            Console.WriteLine("This is the area of a rectangle: " + (width*height));
        }
    }

    public class Property 
    {

        private string name;
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value + "said she love c# ";
            } 
        }
    }
}


