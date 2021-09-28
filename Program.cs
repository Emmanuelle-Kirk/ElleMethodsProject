using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElleMethodsProject
{
    class Program
    {
        static int lives;
        static int health;
        static int score;
        static void HUD()
        {
            Console.WriteLine();
            Console.WriteLine("===============");
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("===============");
            Console.WriteLine();
        }
        static void TakeDamage(int damage)
        {
            health = health - damage;
            Console.WriteLine("OWCH! You were hit!");
        }
        static void MedKit()
        {
            health = health + 25;
            score = score + 25;
            Console.WriteLine("NICE! Medkit pickup!");
        }
        static void Main(string[] args)
        {
            lives = 3;
            health = 100;

            HUD();
            TakeDamage(25);
            HUD();
            TakeDamage(15);
            HUD();
            MedKit();
            HUD();
            TakeDamage(25);
            TakeDamage(25);
            HUD();
            TakeDamage(25);
            HUD();
            TakeDamage(10);
            Console.WriteLine("YOU DIED!");
            lives = lives - 1;
            HUD();
            Console.WriteLine("RESPAWN");
            health = 100;
            score = 0;
            HUD();
            Console.ReadKey(true);
        }
    }
}
