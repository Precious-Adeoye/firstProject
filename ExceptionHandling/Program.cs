using System.Net.Http.Headers;

namespace ExceptionHandling
{
    internal class Program
    {

        static void validate(int age)
        {
            
            if (age < 18 )
            {
                throw new ExceptionC("Student is less then 18");    
            }
        }
        static void Main(string[] args)
        {
            
            //int a = 10;
            //int b = 0;
            //int results = a / b;
            //Console.WriteLine(results);
            //try
            //{
            //    int num1 = 10;
            //    int num2 = 0;
            //    int result = num1 / num2;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}

            //finally
            //{
            //    Console.WriteLine("Then execute this block of code");
            //}

            //Console.WriteLine("The remaining code");


            try
            {
                validate(17);
            }
            catch (ExceptionC C) 
            {
                Console.WriteLine( C );
            }

            Console.WriteLine("Rest of the code");
        }

       
    }
}
