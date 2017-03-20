using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thedescent
{
    class Player
    {
        static void Main(string[] args)
        {
            // game loop
            while (true)
            {
                var hmax = 0;
                var imax = 0;
                for (int i = 0; i < 8; i++)
                {
                    int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.

                    if (mountainH > hmax)
                    {
                        hmax = mountainH;
                        imax = i;
                    }
                }

                Console.WriteLine(imax); // Write an action using Console.WriteLine()
                Console.Error.WriteLine("Debug Error Message"); // To debug: Console.Error.WriteLine("Debug messages...");

            }
        }
    }

