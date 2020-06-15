using System;
using System.Collections.Generic;
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


        public bool Run()
        {
            return true;
        }


        public void TakeStartingPosition()
        {

        }
    }
}
