using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Guy
    {
        public string Name { get; set; }
        public Bet MyBet { get; set; }
        public int Cash { get; set; }
        public RadioButton MyRadioButton { get; set; }
        public Label MyLabel { get; set; }


        public Guy()
        {
            
        }
        

        public void UpdateLabels()
        {

        }


        public void ClearBet()
        {

        }


        public bool PlaceBet(int amount, int dog)
        {
            return true;
        }


        public void Collect(int winner)
        {

        }
    }
}
