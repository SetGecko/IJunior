namespace _5_Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Привет";
            string name = "Пуци";
            string message = greeting + " " + name;
            Console.WriteLine(message + ", рад тебя видеть!");

            int age = 5;
            Console.WriteLine("Привет, завтра тебе исполнится: " + (age + 1));
        }
    }
}