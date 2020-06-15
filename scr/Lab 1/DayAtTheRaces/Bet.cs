using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAtTheRaces
{
    public class Bet
    {
        public int Ammount { get; set; }
        public int Dog { get; set; }
        public Guy Bettor { get; set; }


        public Bet()
        {
            
        }


        public string GetDescription()
        {
            return String.Empty;
        }


        public int PayOut(int winner)
        {
            return Ammount;
        }
    }
}
