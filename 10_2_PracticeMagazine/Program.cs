namespace _10_2_PracticeMagazine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay;

            Console.WriteLine("Добро пожаловать в пекарню! Сегодня еда по " + foodUnitPrice + " монет");
            Console.WriteLine("Сколькот у вас золота?");
            money = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Сколько еды вам нужно?");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= food * foodUnitPrice;
            food *= Convert.ToInt32(isAbleToPay);
            money = money - food * foodUnitPrice;
            Console.WriteLine($"У вас в сумке {food} единиц еды, и {money} монет");


        }
    }
}