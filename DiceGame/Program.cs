using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice. ");
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);
                Console.WriteLine(".......");
                System.Threading.Thread.Sleep(1000);
                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);
            }
            Console.ReadKey();
        }
    }
}
