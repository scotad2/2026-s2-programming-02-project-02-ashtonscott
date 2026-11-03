namespace WinFormsApp1
{
    /// <summary>
    /// The details shared by both the player and the caller.
    /// </summary>
    public abstract class Person
    {
        /// <summary>The person's name.</summary>
        public string Name { get; set; }

        /// <summary>The person's job.</summary>
        public string Job { get; set; }

        /// <summary>
        /// Creates a person.
        /// </summary>
        /// <param name="name">The person's name.</param>
        /// <param name="job">The person's job.</param>
        protected Person(string name, string job)
        {
            Name = name;
            Job = job;
        }
    }
}
