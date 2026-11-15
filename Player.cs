namespace WinFormsApp1
{
    /// <summary>
    /// The contestant playing the game.
    /// </summary>
    public class Player : Person
    {
        private int _age;

        private List<string> _hobbies;

        /// <summary>
        /// Creates a player.
        /// </summary>
        /// <param name="name">The player's name.</param>
        /// <param name="age">The player's age.</param>
        /// <param name="hobbies">The player's hobbies.</param>
        /// <param name="job">The player's job.</param>
        /// <exception cref="Exception">Thrown if the age is not between 1 and 120, or the hobbies list is missing.</exception>
        public Player(string name, int age, List<string> hobbies, string job) : base(name, job)
        {
            // Rubric gives "age is a valid number" as example of validation, because the Player constructor only takes
            // an int for age anyway I figure this just means we don't want the player age to be negative or some crazy, really large number.
            if (age > 120 || age <= 0)
            {
                throw new Exception("The age must be valid (1 - 120).");
            }

            if (hobbies == null)
            {
                throw new Exception("The hobbies list cannot be missing.");
            }

            _age = age;
            _hobbies = hobbies;
        }

        /// <summary>The player's age.</summary>
        public int Age => _age;

        /// <summary>The player's hobbies.</summary>
        public List<string> Hobbies => _hobbies;
    }
}