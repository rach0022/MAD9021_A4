using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD9021_A4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dice d1 = new Dice();

            //for(int i = 0; i < 100000; i++)
            //{
            //    Console.Write("Dice Roll #" + i + ": ");
            //    d1.Roll();
            //    d1.Draw();
            //}

            Dice d1 = new Dice();

            uint[] rolledNumbers = new uint[6];

            for (int i = 0; i < 6000000; i++)
            {
                byte rolledNumber = d1.Roll();

                switch (rolledNumber)
                {
                    case 1:
                        rolledNumbers[0]++;
                        break;
                    case 2:
                        rolledNumbers[1]++;
                        break;
                    case 3:
                        rolledNumbers[2]++;
                        break;
                    case 4:
                        rolledNumbers[3]++;
                        break;
                    case 5:
                        rolledNumbers[4]++;
                        break;
                    case 6:
                        rolledNumbers[5]++;
                        break;

                    default:
                        Console.WriteLine("Dice Error!!");
                        break;
                }
            }

            // output

            Console.WriteLine("Dice Statistics:\n\n");

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"\t   {i + 1}\t");
            }

            string dashes = new string('-', 100);

            Console.WriteLine();
            Console.WriteLine(dashes);

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"\t{rolledNumbers[i]}\t");
            }

            Console.WriteLine("\n");

            d1.Draw();


            Console.WriteLine("\nPress any key to continue. . .");
            Console.ReadKey();

        }
    }
}
