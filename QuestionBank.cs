namespace WinFormsApp1
{
    /// <summary>
    /// Holds all the questions and hands them out at random without repeats.
    /// </summary>
    public class QuestionBank
    {
        /// <summary>The questions that have not been asked yet.</summary>
        private readonly List<Question> _questions;

        /// <summary>Used to pick a random question.</summary>
        private readonly Random _random = new();

        /// <summary>
        /// Creates the bank from a list of questions.
        /// </summary>
        /// <param name="questions">The questions loaded from the JSON file.</param>
        public QuestionBank(List<Question> questions)
        {
            _questions = questions;
        }

        /// <summary>
        /// Picks a random question for the category and difficulty, then removes it so it can't be asked again.
        /// </summary>
        /// <param name="category">The chosen category.</param>
        /// <param name="difficulty">The current difficulty (easy, medium or hard).</param>
        /// <returns>A question, or null if none are left.</returns>
        public Question GetRandomQuestion(string category, string difficulty)
        {
            // Probably could have used LINQ here but I feel this is more readable.

            // Collect every question that has the right category and difficulty.
            List<Question> matches = new List<Question>();
            foreach (Question question in _questions)
            {
                if (question.Category == category && question.Difficulty == difficulty)
                {
                    matches.Add(question);
                }
            }

            // Check if there are no questions left.
            if (matches.Count == 0)
            {
                return null;
            }

            // Pick one at random from the matches.
            int randomIndex = _random.Next(matches.Count);
            Question chosen = matches[randomIndex];

            // Remove it from the main list so it is never asked twice.
            _questions.Remove(chosen);
            return chosen;
        }
    }
}