namespace Collections
{
    internal class Program
    {
        delegate int Square(int x);

        delegate void Notice(string message);
        class Process
        {
            public void Start(Notice callback)
            {
                Console.WriteLine("Process started");
                callback("process has started");
            }

        }
        static void Main(string[] args)
        {
            //var names = new List<string>();
            // names.Add("Stephen Bakare");
            // names.Add("Funmi Grace");
            // names.Add("Eloho Jane");

            // foreach (var item in names)
            // {
            //     Console.WriteLine(item);
            // }

            // var students = new HashSet<string>()
            // {
            //     "Jane",
            //     "Kate",
            //     "Hera",
            //     "Jane"
            // };

            // foreach (var s in students)
            // {
            //     Console.WriteLine(s);
            // }

            // SortedSet<int> numbers = new SortedSet<int>()
            // {
            //     7,1,2,3,7,8
            // };

            // foreach(var n in numbers)
            // {
            //     Console.WriteLine(n);
            // }

            // var num = new Stack<int>();
            // num.Push(7);
            // num.Push(12);
            // num.Push(5);
            // foreach (var item in num)
            // {
            //     Console.WriteLine(item);
            // }

            //var names = new LinkedList<string>();
            //{
            //    names.AddLast("Stella");
            //    names.AddLast("Eloho");
            //    names.AddFirst("Funmi");
            //    names.AddLast("Stephen");

            //    LinkedListNode<string> node = names.Find("Stephen");
            //    names.AddBefore(node, "Stella");
            //    names.AddAfter(node, "Tracy");
            //};

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);   
            //}

            //var Dic = new Dictionary<int, string>();
            //Dic.Add(1, "Eloho");
            //Dic.Add(2, "Chris");
            //Dic.Add(3, "Funmi");

            //foreach (KeyValuePair<int, string> D in Dic)
            //{
            //    Console.WriteLine($"{D.Key} {D.Value}");
            //}

            //GenericExamples<string> Ex = new GenericExamples<string>("This is a string generic examples");
            //Console.WriteLine(Ex);

            //GenericExamples<int> num = new GenericExamples<int>(123);
            //Console.WriteLine("This is : " + num);

            //GenericExamples<char> letter = new GenericExamples<char>('A');

            Square GetSquare = x => x * x;
            int num = 3;
            int s = GetSquare(num);

            //List<Student> students = new List<Student>() 
            //{
            //    new Student{Name = "Grace",  Age= 25},
            //    new Student{Name = "Eloho", Age= 30},
            //    new Student{Name = "Funmi", Age = 30},
            //    new Student{Name = "Tolu", Age = 12}
            //};

            //var names = students
            //    .Where(s => s.Age < 17)
            //    .Select(s => s.Name);
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            Process p = new Process();
            p.Start(msg => Console.WriteLine($"callback received: {msg}"));
        }
    }
}
