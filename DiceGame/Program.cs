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
            int playerPoints = 0;
            int enemyPoints = 0;
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
                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round! ");
                }
                else if (enemyRandomNum > playerRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round! ");
                } else
                {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("The Score now is - Player : " + playerPoints);
                Console.WriteLine("The Score now is - Enemy : " + enemyPoints);
                
            }
            if (playerPoints>enemyPoints) 
            {
                Console.WriteLine("Player Won!!!");
            } else
            {
                Console.WriteLine("Enemy Won!!!");
            }
            Console.ReadKey();
        }
    }
}
