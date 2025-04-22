using System.Security.Principal;

namespace firstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 123468903;
            //int num = 10;

            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);

            //double d = 123.412;

            //float f = 30.14f;

            //char c = 'A';

            //int _num = 10;

            //string word = "This is a string";
            //Console.WriteLine(word);

            //int a = 5;
            //int *p = &a; // Pointer to a


            //int data = 10 + 5 * 5;
            //Console.WriteLine(data);

            //int number = 10;
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");

            //}

            //Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("It is even");
            //}
            //else
            //{
            //    Console.WriteLine("It is odd");
            //}

            ////ladder if else statement
            //Console.WriteLine("Enter a number to check grade");
            //int grade = Convert.ToInt32(Console.ReadLine());
            //if (grade < 0 || grade > 100)
            //{
            //    Console.WriteLine("wrong number");
            //}
            //else if (grade >= 0 && grade < 50)
            //{
            //    Console.WriteLine("fail");
            //}
            //else if (grade >= 50 && grade < 60)
            //{
            //    Console.WriteLine("D grade");
            //}
            //else if (grade >= 60 && grade < 70)
            //{
            //    Console.WriteLine("c grade");
            //}
            //else
            //{
            //    Console.WriteLine("A grade");
            //}

            //Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //switch (num)
            //{
            //    case 10: Console.WriteLine("it is 10"); break;
            //        case 20: Console.WriteLine("it is 20"); break;
            //        case 30: Console.WriteLine("30"); break;
            //    default: Console.WriteLine("Not 10, 20,30"); break;
            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}

            ////while loop
            //int j = 0;
            //while (j <= 10)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}

            //int k = 0;
            //do
            //{
            //    Console.WriteLine(k); 
            //    k++;
            //}
            //while (k <= 2);

            //Console.Write("What do you want to repeat?: ");
            //string message = Console.ReadLine();

            //Console.Write("Add how many times you want to repeat it: ");
            //int loopCounter = Convert.ToInt32(Console.ReadLine());

            //if (loopCounter <= 0)
            //{
            //    Console.WriteLine("Sorry, please enter a value above 0");
            //}
            //else
            //{
            //    for (int i = 0; i < loopCounter; i++)
            //    {
            //        Console.WriteLine(message);   
            //    }
            //}

            //Functions fs = new Functions();
            //fs.Show();

            //Functions fs1 = new Functions();
            //fs1.Show("Hello");

            //int val = 50;
            //Functions fs2 = new Functions();
            //Console.WriteLine("value before calling the function" + val);
            //fs2.show(val);
            //Console.WriteLine("value after calling the function" + val);


            //int val = 50;
            //Functions functions = new Functions();
            //Console.WriteLine("value before calling the function" + val);
            //functions.Show(ref val);
            //Console.WriteLine("value after calling the function" + val);

            //int val = 50;
            //Functions function = new Functions();
            //Console.WriteLine("value before calling the function" + val);
            //function.flow(out val);
            //Console.WriteLine("value after calling the function" + val);


            //int[] arr = new int[5];
            //arr[0] = 10;
            //arr[3] = 20;
            //arr[2] = 15;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int[,] arr = { { 1,2,3}, {4, 5, 6 }, { 7, 8, 9 } };
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(arr[i,j] + " ");
            //    }
            //}

            //ClassObject classObject = new ClassObject();
            //classObject.id = 1;
            //classObject.name = "John Doe";

            //Console.WriteLine(classObject.id);
            //Console.WriteLine(classObject.name);

            //ClassObject co1 = new ClassObject();
            //ClassObject co2 = new ClassObject();
            //ClassObject co3 = new ClassObject();
            //co1.insert(10, "Funmi");
            //co2.insert(20, "Eloho");
            //co3.insert(30, "Stephen");
            //co1.display();
            //co2.display();
            //co3.display();

            //ClassObject classObject = new ClassObject(10, "funmi");
            //ClassObject classObject1 = new ClassObject(20, "Eloho");
            //ClassObject classObject2 = new ClassObject(30, "Stephen");
            //classObject.display();
            //classObject1.display();
            //classObject2.display();

            //Console.WriteLine("Total Objects are: " + ClassObject.count);

            //Console.WriteLine("value of Pi is: " + Sclass.pi);
            //Console.WriteLine("cube of 3 is: " + Sclass.cube(3));

            //ClassObject obj = new ClassObject(10, "Funmi");
            //ClassObject obj1 = new ClassObject(20, "Eloho");
            //obj1.display();
            //obj.display();

            //Example example = new Example(4, 7);
            //example.show();

            //int x = (int)Season.Autumn;
            //int y = (int)Season.Winter;
            //int z = (int)Season.Spring;
            //Console.WriteLine("Autumn {0} ", x);
            //Console.WriteLine("Winter {0} ", y);
            //Console.WriteLine("Spring {0} ", z);

            //foreach (Days d in Enum.GetValues(typeof(Days)))
            //{
            //    Console.WriteLine(d);
            //}

            Property property = new Property();
            property.Name = "Funmi";
            Console.WriteLine("Property name is " + property.Name);
        }

        public enum Season
        {
            Spring = 20,
            Summer,
            Autumn,
            Winter
        }

        public enum Days
        {
            Sunday ,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }

}
