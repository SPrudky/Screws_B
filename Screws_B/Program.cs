using System;

namespace Screws_B
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double onePiece;
            double allpieces;
            double count;
            
            Console.WriteLine("Screw managment application");
            Console.WriteLine("--------------------------------------");
           
            Console.WriteLine("Set one piece weight (g): ");
            double.TryParse(Console.ReadLine(), out onePiece );
            if (onePiece <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Only values above 0 are allowed");
            }
            else
            {



                Console.WriteLine("Set all piece weight (g): ");
                allpieces = double.Parse(Console.ReadLine());
                if (allpieces <= 0)
                {
                    Console.WriteLine("Only values above 0 are allowed");
                }
                else
                {



                    count = allpieces / onePiece;
                    count = Math.Floor(count);

                    Console.WriteLine();
                    Console.WriteLine($"You have {count} pieces. ");
                }
            }

            Console.ReadLine();

        }  

    }
}
