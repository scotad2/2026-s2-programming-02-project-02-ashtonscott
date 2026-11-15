namespace WinFormsApp1
{
    /// <summary>
    /// The details shared by both the player and the caller.
    /// </summary>
    public abstract class Person
    {
        private string _name;

        private string _job;

        /// <summary>
        /// Creates a person.
        /// </summary>
        /// <param name="name">The person's name.</param>
        /// <param name="job">The person's job.</param>
        /// <exception cref="Exception">Thrown if the name or job is empty.</exception>
        protected Person(string name, string job)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("The name cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(job))
            {
                throw new Exception("The job cannot be empty.");
            }

            _name = name;
            _job = job;
        }

        /// <summary>The person's name.</summary>
        public string Name => _name;

        /// <summary>The person's job.</summary>
        public string Job => _job;
    }
}