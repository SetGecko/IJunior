namespace _3_ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // + - * / %
            float result;
            int x, y;

            x = 5;
            y = 2;

            result = Convert.ToSingle(x) / y;
            // Convert.ToSingle(x) = covert to float
            Console.WriteLine(result);

            int timeInMinutes = 130;
            int hour;
            int minute;

            hour = timeInMinutes / 60;
            minute = timeInMinutes % 60;
            
            Console.WriteLine("hours: " + hour);
            Console.WriteLine("minutes: " + minute);


        }
    }
}