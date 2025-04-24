namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dad dad = new Dad("Abdi", "AA", 45, "Abdi");
            Child child = new Child("5.5", 21, dad);

            child.Show();
            
            string message = "Hello World!";
            int length = message.Length;
            Console.WriteLine($"The length of the message is: {length}");
        }
    }
}
