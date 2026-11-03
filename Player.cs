using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// The contestant playing the game.
    /// </summary>
    public class Player : Person
    {
        /// <summary>The player's age.</summary>
        public int Age { get; set; }

        /// <summary>The player's hobbies.</summary>
        public List<string> Hobbies { get; set; }

        /// <summary>
        /// Creates a player.
        /// </summary>
        /// <param name="name">The player's name.</param>
        /// <param name="age">The player's age.</param>
        /// <param name="hobbies">The player's hobbies.</param>
        /// <param name="job">The player's job.</param>
        public Player(string name, int age, List<string> hobbies, string job) : base(name, job)
        {
            Age = age;
            Hobbies = hobbies;
        }
    }
}
