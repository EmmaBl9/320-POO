using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////
            //   Décclaration variables   //
            List<Snail> snails = new List<Snail>();

            Snail toto = new Snail(10);
            Snail titi = new Snail(13);

            for (int i = 0; i < 10; i++)
            {
                snails.Add(new Snail(i));
            }

            ////////////////////////////////

            Console.CursorVisible = false;

            do
            {
                foreach (Snail snail in snails)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(snail.X, snail.y);
                    Console.WriteLine(snail.alive);
                    snail.Move();
                }
                Thread.Sleep(50);
                Console.Clear();
            }
            while (snails.First().pifle > 0);
            foreach (Snail snail in snails)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(snail.X, snail.y);
                Console.WriteLine(snail.dead);
            }


            //Game over
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(47, 15);
            Thread.Sleep(1000);
            Console.WriteLine("*Game Over*");

            Console.ReadLine();
        }
    }
}
