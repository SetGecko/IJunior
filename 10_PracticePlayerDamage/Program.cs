namespace _10_PracticePlayerDamage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float health;
            int armor;
            int damage;
            int percentConverter = 100;

            Console.Write("Введите количество здоровья: ");
            health = Convert.ToInt32(Console.ReadLine());   
            
            Console.Write("Введите количество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());   
            
            Console.Write("Введите количество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= damage * armor / percentConverter;
            // health = 100 - ((50 * 50) / 100)

            Console.WriteLine($"Вам нанесли {damage} урона. " +
                $"У вас осталось {health} здоровья");



        }
    }
}