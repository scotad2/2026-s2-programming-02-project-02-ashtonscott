namespace WinFormsApp1
{
    /// <summary>
    /// The prize ladder: keeps track of the current level and what the player has won.
    /// </summary>
    public class MoneyTree
    {
        /// <summary>Prize for each level, lowest first.</summary>
        private static readonly int[] Prizes =
        {
            100, 200, 300, 500, 1000, 2000, 4000, 8000, 16000, 32000,
            64000, 125000, 250000, 500000, 1000000
        };

        /// <summary>The current level, starting at 0.</summary>
        public int Level { get; private set; }

        /// <summary>The number of levels.</summary>
        public int LevelCount => Prizes.Length;

        /// <summary>The prize for the current question.</summary>
        public int PlayingFor => Prizes[Level];

        /// <summary>What the player has won so far.</summary>
        public int Score => Level == 0 ? 0 : Prizes[Level - 1];

        /// <summary>The question difficulty for the current level.</summary>
        public string Difficulty
        {
            get
            {
                if (Level < 5)
                {
                    return "easy";
                }
                else if (Level < 10)
                {
                    return "medium";
                }
                else
                {
                    return "hard";
                }
            }
        }
    }
}