using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition { get; set; }
        public int RacetrackLength { get; set; }
        public PictureBox MyPictureBox { get; set; }
        public int Location { get; set; }
        public Random Randomiser { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Greyhound"/> class.
        /// </summary>
        /// <param name="myPictureBox">My PictureBox.</param>
        /// <param name="racetrackLength">Length of the racetrack.</param>
        /// <param name="randomiser">The randomiser.</param>
        public Greyhound(PictureBox myPictureBox, int racetrackLength, Random randomiser)
        {
            MyPictureBox = myPictureBox;
            RacetrackLength = racetrackLength;
            Randomiser = randomiser;

            StartingPosition = MyPictureBox.Left;
            Location = StartingPosition;
        }


        /// <summary>
        /// Runs this instance.
        /// </summary>
        /// <returns></returns>
        public bool Run()
        {
            Point myPictureBoxLocation = MyPictureBox.Location;
            int distance = Randomiser.Next(1, 4);

            myPictureBoxLocation.X += distance;
            MyPictureBox.Location = myPictureBoxLocation;
            Location += myPictureBoxLocation.X;

            if (Location >= RacetrackLength - MyPictureBox.Width)
                return true;

            return false;
        }


        /// <summary>
        /// Takes the starting position.
        /// </summary>
        public void TakeStartingPosition()
        {
            MyPictureBox.Left = StartingPosition;
            Location = StartingPosition;
        }
    }
}
