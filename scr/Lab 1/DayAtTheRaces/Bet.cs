namespace DayAtTheRaces
{
    public class Bet
    {
        public int Amount { get; set; }
        public int Dog { get; set; }
        public Guy Bettor { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Bet"/> class.
        /// </summary>
        /// <param name="amount">The amount to bet.</param>
        /// <param name="dog">The dog the bet was placed against.</param>
        /// <param name="bettor">The bettor who placed the bet.</param>
        public Bet(int amount, int dog, Guy bettor)
        {
            Amount = amount;
            Dog = dog;
            Bettor = bettor;
        }


        /// <summary>
        /// Gets the bet's description.
        /// </summary>
        /// <returns>The bet's description</returns>
        public string GetDescription()
        {
            return Amount > 0 ? 
                $"{Bettor.Name} bets {Amount} on dog #{Dog}" : 
                $"{Bettor.Name} hasn't placed a bet";
        }


        /// <summary>
        /// Pays out the winning amount if the dog won.
        /// Takes away the amount if the dog didn't win.
        /// </summary>
        /// <param name="winner">The winning dog number.</param>
        /// <returns>The change in cash.</returns>
        public int PayOut(int winner)
        {
            if (Dog == winner)
                return Amount;

            return -Amount;
        }
    }
}
