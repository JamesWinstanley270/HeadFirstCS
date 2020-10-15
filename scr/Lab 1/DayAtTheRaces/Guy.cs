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


        /// <summary>
        /// Initializes a new instance of the <see cref="Guy"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cash">The cash.</param>
        /// <param name="myRadioButton">My RadioButton.</param>
        /// <param name="myLabel">My label.</param>
        public Guy(string name, int cash, RadioButton myRadioButton, Label myLabel)
        {
            Name = name;
            Cash = cash;
            MyRadioButton = myRadioButton;
            MyLabel = myLabel;

            MyBet = null;
            UpdateLabels();
        }


        /// <summary>
        /// Updates the guy's labels.
        /// </summary>
        public void UpdateLabels()
        {
            if (MyBet != null)
                MyLabel.Text = MyBet.GetDescription();

            MyRadioButton.Text = $"{Name} has {Cash} bucks";
        }


        /// <summary>
        /// Clears the bet.
        /// </summary>
        public void ClearBet()
        {
            MyBet = null;
        }


        /// <summary>
        /// Places the bet.
        /// </summary>
        /// <param name="amount">The amount to bet.</param>
        /// <param name="dog">The dog to bet on.</param>
        /// <returns></returns>
        public bool PlaceBet(int amount, int dog)
        {
            if (Cash < amount)
                return false;

            MyBet = new Bet(amount, dog, this);
            UpdateLabels();

            return true;
        }


        /// <summary>
        /// Collect any winnings.
        /// </summary>
        /// <param name="winner">The winner.</param>
        public void Collect(int winner)
        {
            Cash += MyBet.PayOut(winner);
            UpdateLabels();
        }
    }
}
