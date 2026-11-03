namespace WinFormsApp1
{
    /// <summary>
    /// A friend the player can phone for help.
    /// </summary>
    public class Caller : Person
    {
        /// <summary>Categories the caller knows well.</summary>
        public List<string> Strengths { get; set; }

        /// <summary>Categories the caller knows poorly.</summary>
        public List<string> Weaknesses { get; set; }

        /// <summary>
        /// Creates a caller.
        /// </summary>
        /// <param name="name">The caller's name.</param>
        /// <param name="job">The caller's job.</param>
        /// <param name="strengths">Categories the caller knows well.</param>
        /// <param name="weaknesses">Categories the caller knows poorly.</param>
        public Caller(string name, string job, List<string> strengths, List<string> weaknesses) : base(name, job)
        {
            Strengths = strengths;
            Weaknesses = weaknesses;
        }
    }
}
