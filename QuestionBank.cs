namespace WinFormsApp1
{
    /// <summary>
    /// Holds all the questions and hands them out at random without repeats.
    /// </summary>
    public class QuestionBank
    {
        private readonly List<Question> _questions;
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
        public Question? GetRandomQuestion(string category, string difficulty)
        {
            List<Question> matches = _questions
                .Where(q => q.Category == category && q.Difficulty == difficulty)
                .ToList();

            if (matches.Count == 0)
            {
                return null;
            }

            Question chosen = matches[_random.Next(matches.Count)];
            _questions.Remove(chosen);
            return chosen;
        }
    }
}
