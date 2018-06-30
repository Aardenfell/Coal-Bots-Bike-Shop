using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VTBike
{
    class Program
    {

        public static class Answer
        {
            public static string answer { get; }
        }
        static void Main(string[] args)
        {
            string answer;
            int tyre; 
            int streamers;

            Console.WriteLine("Hello! Welcome to my bike shop!");
            Console.WriteLine("My name is [Coal]");
            Thread.Sleep(1000);
            tryAgain:
            Console.WriteLine("How many tyres would you like on your bike?");
            try
            {
                tyre = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("That's a bit too many tyres there buddy.");
                Console.WriteLine("Try again");
                goto tryAgain;
            }
            do
            {
                // Junk Bike
                if (tyre < 2)
                {
                    askAgain:
                    Console.WriteLine("Would you like to add some streamers?");
                    Console.WriteLine("[Y/N]");
                    answer = Console.ReadLine();
                    if (answer == "N" || answer == "n")
                    {
                        Console.WriteLine("Alrighty");
                        goto junkBike;
                    }
                    else if (answer == "Y" || answer == "y")
                    {
                        tryAgainStreamers:
                        Console.WriteLine("How many?");
                        try
                        {
                            streamers = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("That's a bit too many tyres there buddy.");
                            Console.WriteLine("Try again");
                            goto tryAgainStreamers;
                        }
                        if (streamers > 0)
                        {
                            goto junkHasStreams; 
                        }
                    }
                    else if (answer != "Y" || answer != "y" || answer != "N" || answer != "n")
                    {
                        Console.WriteLine("I'm sorry. I don't understand that");
                        Thread.Sleep(1000);
                        goto askAgain;
                    }
                }

                // Normal Bike
                else if (tyre == 2)
                {
                    askAgain:
                    Console.WriteLine("Would you like to add some streamers?");
                    Console.WriteLine("[Y/N]");
                    answer = Console.ReadLine();
                    if (answer == "N" || answer == "n")
                    {
                        Console.WriteLine("Alrighty");
                        goto normalBike;
                    }
                    else if (answer == "Y" || answer == "y")
                    {
                        tryAgainStreamers:
                        Console.WriteLine("How many?");
                        try
                        {
                            streamers = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("That's a bit too many tyres there buddy.");
                            Console.WriteLine("Try again");
                            goto tryAgainStreamers;
                        }
                        if (streamers == 2)
                        {
                            goto normalMumsBike; 
                        }
                        else if (streamers >= 3)
                        {
                            goto normalBikeStream; 
                        }
                    }
                    else if (answer != "Y" || answer != "y" || answer != "N" || answer != "n")
                    {
                        Console.WriteLine("I'm sorry. I don't understand that");
                        Thread.Sleep(1000);
                        goto askAgain;
                    }
                }

                // Trike
                else if (tyre == 3)
                {
                    askAgain:
                    Console.WriteLine("Would you like to add some streamers?");
                    Console.WriteLine("[Y/N]");
                    answer = Console.ReadLine();
                    if (answer == "N" || answer == "n")
                    {
                        Console.WriteLine("Alrighty");
                        goto trikeBike;
                    }
                    else if (answer == "Y" || answer == "y")
                    {
                        tryAgainStreamers:
                        Console.WriteLine("How many?");
                        try
                        {
                            streamers = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("That's a bit too many tyres there buddy.");
                            Console.WriteLine("Try again");
                            goto tryAgainStreamers;
                        }
                        if (streamers > 0)
                        {
                            goto trikeHasStreams; 
                        }
                        
                    }
                    else if (answer != "Y" || answer != "y" || answer != "N" || answer != "n")
                    {
                        Console.WriteLine("I'm sorry. I don't understand that");
                        Thread.Sleep(1000);
                        goto askAgain;
                    }
                }

                // Monster Bike
                else if (tyre >= 4)
                {
                    askAgain:
                    Console.WriteLine("Would you like to add some streamers?");
                    Console.WriteLine("[Y/N]");
                    answer = Console.ReadLine();
                    if (answer == "N" || answer == "n")
                    {
                        Console.WriteLine("Alrighty");
                        goto monsterBike;
                    }
                    else if (answer == "Y" || answer == "y")
                    {
                        tryAgainStreamers:
                        Console.WriteLine("How many?");
                        try
                        {
                            streamers = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("That's a bit too many tyres there buddy.");
                            Console.WriteLine("Try again");
                            goto tryAgainStreamers;
                        }
                        if (streamers > 0)
                        {
                            goto monsterHasStreams; 
                        }
                    }
                    else if (answer != "Y" || answer != "y" || answer != "N" || answer != "n")
                    {
                        Console.WriteLine("I'm sorry. I don't understand that");
                        Thread.Sleep(1000);
                        goto askAgain;
                    }
                }
            } while (answer == "Y" || answer == "y");

            junkBike:
            Console.WriteLine("Creating..");
            Bike junker = new Bike(0, 0);

            
            junker.ChangeTyresWhile();
            Console.WriteLine(junker.GetBikeDesc());
            Console.WriteLine(junker.GetTypeBike());

            Console.WriteLine();
            Console.WriteLine();
            
            // End

            junkHasStreams:
            Console.WriteLine("Creating..");
            Bike junkerStreams = new Bike(0, 0);


            junkerStreams.ChangeTyresWhile();
            Console.WriteLine(junkerStreams.GetBikeDesc());
            Console.WriteLine(junkerStreams.GetTypeBike());

            Console.WriteLine();
            Console.WriteLine();

            normalBike:
            Console.WriteLine("Creating..");
            Bike normal = new Bike(2, 0);


            normal.ChangeTyresWhile();
            Console.WriteLine(normal.GetBikeDesc());
            Console.WriteLine(normal.GetTypeBike());

            Console.WriteLine();
            Console.WriteLine();

            // End

            normalMumsBike:
            Console.WriteLine("Creating..");
            Bike normalMums = new Bike(2, 2);


            normalMums.ChangeTyresWhile();
            Console.WriteLine(normalMums.GetBikeDesc());
            Console.WriteLine(normalMums.GetTypeBike());

            Console.WriteLine();
            Console.WriteLine();

            // End

            normalBikeStream:
            Console.WriteLine("Creating..");
            Bike normalStreams = new Bike(2, 0);


            normalStreams.ChangeTyresWhile();
            Console.WriteLine(normalStreams.GetBikeDesc());
            Console.WriteLine(normalStreams.GetTypeBike());

            Console.WriteLine();
            Console.WriteLine();

            // End

            trikeBike:
            Console.WriteLine("Creating..");
            Bike trike = new Bike(3, 0);


            trike.ChangeTyresWhile();
            Console.WriteLine(trike.GetBikeDesc());
            Console.WriteLine(trike.GetTypeBike());

            Console.WriteLine();
            Console.WriteLine();

            // End

            trikeHasStreams:
            Console.WriteLine("Creating..");
            Bike trikeStreams = new Bike(0, 0);


            trikeStreams.ChangeTyresWhile();
            Console.WriteLine(trikeStreams.GetBikeDesc());
            Console.WriteLine(trikeStreams.GetTypeBike());

            Console.WriteLine();
            Console.WriteLine();

            // End

            monsterBike:
            Console.WriteLine("Creating..");
            Bike monster = new Bike(0, 0);


            monster.ChangeTyresWhile();
            Console.WriteLine(monster.GetBikeDesc());
            Console.WriteLine(monster.GetTypeBike());

            Console.WriteLine();
            Console.WriteLine();

            // End

            monsterHasStreams:
            Console.WriteLine("Creating..");
            Bike monsterStreams = new Bike(0, 0);


            monsterStreams.ChangeTyresWhile();
            Console.WriteLine(monsterStreams.GetBikeDesc());
            Console.WriteLine(monsterStreams.GetTypeBike());

            Console.WriteLine();
            Console.WriteLine();

            // End

        }
    }
}
