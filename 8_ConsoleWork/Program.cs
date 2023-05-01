namespace _8_ConsoleWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine($"Ваше имя: {name}");

            int age;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш возраст {age}");
        }
    }
}