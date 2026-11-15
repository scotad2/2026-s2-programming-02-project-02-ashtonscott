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
        public Player(string name, int age, List<string> hobbies, string job) : base(name, job)
        {
            _age = age;
            _hobbies = hobbies;
        }

        /// <summary>The player's age.</summary>
        public int Age => _age;

        /// <summary>The player's hobbies.</summary>
        public List<string> Hobbies => _hobbies;
    }
}