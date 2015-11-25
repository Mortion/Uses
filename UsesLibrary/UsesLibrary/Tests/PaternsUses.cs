using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesLibrary.Tests
{
    public class PaternsUses
    {
        public int Count { get; set; }

        public PaternsUses()
        {

        }

        private int band = 5;

        public void ArrowScarf(int length, int width)
        {
            Count = 0;
            Band(width);

            var frontNback = 2;

            var mid = width - frontNback * 2;
            mid -= 6;
            int count = 4;


            for (int i = 0; i < (length - (band * 2)); i++)
            {
                if (Count > 9)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(Count + ". ");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(Count + ".  ");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
               

                if (((frontNback * 2) + mid + 6) > width)
                {

                   
                    for (int j = 0; j < frontNback; j++)
                    {
                        Console.Write("X");
                    }

                    Console.ForegroundColor = ConsoleColor.White;


                    for (int j = 0; j < count; j++)
                    {
                        Console.Write("X");
                    }



                    Console.ForegroundColor = ConsoleColor.Red;

                    count-=2;

                    for (int j = 0; j < frontNback; j++)
                    {
                        Console.Write("X");
                    }



                }
                else
                {
                    
                    for (int j = 0; j < frontNback; j++)
                    {
                        Console.Write("X");
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("XXX");
                    Console.ForegroundColor = ConsoleColor.Red;

                    for (int j = 0; j < mid; j++)
                    {
                        Console.Write("X");
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("XXX");
                    Console.ForegroundColor = ConsoleColor.Red;

                    for (int j = 0; j < frontNback; j++)
                    {
                        Console.Write("X");
                    }
                }


                if ((frontNback * 2 >= width))
                {
                    break;
                    
                }
                else
                {
                    ++frontNback;
                }



                mid = width - frontNback * 2;
                if ((mid - 6) > 0)
                {
                    mid -= 6;

                }
                else
                {
                    mid = 0;
                }
                Count++;
            }
           
            Band(width);

        }


        public void Band(int width)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < band; i++)
            {
                if (Count > 9)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(Count + ". ");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(Count + ".  ");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                for (int j = 0; j < width; j++)
                {
                    Console.Write("X");
                }
                Count++;
            }
        }

    }
}
