using System;

namespace time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game time calculator ");
            
            Console.WriteLine("enter hours played ");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Minutes");
            int Minuets = int.Parse(Console.ReadLine());

            int finaltotal = hours * 60 + Minuets;

            Console.WriteLine(finaltotal);

            if(finaltotal>120)
            {
                Console.WriteLine("you've played for too long");
            }
            else
            {
                Console.WriteLine("you are under your limit");
            }
        }
    }
}
