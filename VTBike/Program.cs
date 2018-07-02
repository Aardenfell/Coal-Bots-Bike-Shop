using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VTBike
{
    class Program
    {

       
        static void Main(string[] args)
        {
            int tyre = 0; 
            int streamers = 0;
            bool hasChosenTyres = false;
            bool hasChosenStreamers = false;
            Bike myBike;
            


            Console.WriteLine("Hello! Welcome to my bike shop!");
            Console.WriteLine("My name is [Coal]");
            Thread.Sleep(1000);
            
            
            while (hasChosenTyres == false)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("How many tyres would you like?");
                Console.ResetColor();
                try
                {
                    tyre = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                    Console.ResetColor();
                }
                hasChosenTyres = true;
            }
            while (hasChosenStreamers == false)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("How many streamers would you like?");
                Console.ResetColor();
                try
                {
                    streamers = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                    Console.ResetColor();
                    
                    
                }
                hasChosenStreamers = true;
            }

           
            if (tyre >= 0)
            {
                Console.WriteLine("Creating..");

                myBike = new Bike(tyre, streamers);

                Console.ForegroundColor = ConsoleColor.Green;
                myBike.ChangeTyresWhile();
                Thread.Sleep(2000);
                Console.ResetColor();
                Console.WriteLine(myBike.GetBikeDesc());
                Thread.Sleep(2000);
                Console.WriteLine(myBike.GetTypeBike());
                Thread.Sleep(2000);
            }


            // End
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }
    } 
}
