using System;
using System.Collections.Generic;

namespace VTBike
{   /// <summary>
    ///  Bike Object
    /// </summary>
    class Bike
    {
        /// <summary>
        ///  Gets set number of tyres
        /// </summary>
        public int NumOfTyres { get; set; }

        /// <summary>
        /// Gets set number of Streamers
        /// </summary>
        public int NumOfStreamers { get; set; }

        /// <summary>
        /// Initialize the bike
        /// </summary>
        /// <param name="tyreCount">Number of tyres.</param>
        /// <param name="streamerCount">Number of streamers.</param>
        public Bike(int tyreCount, int streamerCount)
        {
            // Setup
            this.NumOfTyres = tyreCount;
            this.NumOfStreamers = streamerCount;
        }


        public string GetBikeDesc()
        {
            return "This bad boy has " + this.NumOfTyres + " wheels and " + this.NumOfStreamers + " streamers on it. Rad";
        }
        
        public string GetTypeBike()
        {
            if (this.NumOfTyres < 2)
            {
                return "Your Bike is a Piece of Junk";
            }
            else if (this.NumOfTyres == 2 && this.NumOfStreamers != 2)
            {
                return "Your Bike is a pretty Normal Bike";
            }
            else if (this.NumOfTyres == 3)
            {
                return "You have a Tricycle";
            }
            else if (this.NumOfTyres > 3)
            {
                return "This thing isn't a bike";
            }
            else if (this.NumOfTyres == 2 && this.NumOfStreamers == 2)
            {
                return "You have your mum's bike. Why are you using that thing?";
            }
            return "wat";
        }

        /// <summary>
        /// Change tyres with loop
        /// </summary>
        public void ChangeTyresWhile()
        {
            if (this.NumOfTyres <= 0)
            {
                Console.WriteLine("No tyres need to be changed here");
                return;
            }

            List<int> removedTyres = new List<int>();
            int tyreNum = 0;

            while (removedTyres.Count < this.NumOfTyres)
            {
                tyreNum++;
                Console.WriteLine("Removing Tyre " + tyreNum);
                removedTyres.Add(tyreNum);
            }

            do
            {
                Console.WriteLine("Replacing Tyre " + removedTyres[0]);
                removedTyres.RemoveRange(0, 1);
                tyreNum--;
            } while (tyreNum > 0);
        }
    }
}
