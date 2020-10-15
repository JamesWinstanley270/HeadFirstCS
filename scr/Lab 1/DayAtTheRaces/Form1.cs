using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {
        private Random _random;


        public Guy[] Guys { get; set; }
        public Greyhound[] Greyhounds { get; set; }


        public Form1()
        {
            InitializeComponent();
            InitializeGuys();
            InitializeGreyhounds();
        }


        /// <summary>
        /// Initializes the guys.
        /// </summary>
        private void InitializeGuys()
        {
            Guys[0] = new Guy("Joe", 50, radJoe, lblJoesLabel);
            Guys[1] = new Guy("Bob", 75, radBob, lblBobsLabel);
            Guys[2] = new Guy("Al", 45, radAl, lblAlsLabel);
        }


        /// <summary>
        /// Initializes the greyhounds.
        /// </summary>
        private void InitializeGreyhounds()
        {
            int racetrackLength = picRacetrack.Width;
            Greyhounds[0] = new Greyhound(picGreyhound1, racetrackLength, _random);
            Greyhounds[1] = new Greyhound(picGreyhound2, racetrackLength, _random);
            Greyhounds[2] = new Greyhound(picGreyhound3, racetrackLength, _random);
            Greyhounds[3] = new Greyhound(picGreyhound4, racetrackLength, _random);
        }


        private void btnPlaceBet_Click(object sender, EventArgs e)
        {

            if (radJoe.Checked)
            {

            }
        }
    }
}
