using System.Net;
using System.Text.Json;

namespace WinFormsApp1
{
    /// <summary>
    /// Loads the questions from the JSON file.
    /// </summary>
    public static class DataHandler
    {
        private const string QuestionPath = @"../../../data/all-questions.json";

        /// <summary>
        /// Reads the JSON file and decodes any HTML entities (e.g. &amp;quot;) in the text.
        /// </summary>
        /// <param name="filePath">Path to the JSON file.</param>
        /// <returns>All questions in the file.</returns>
        public static List<Question> LoadQuestions()
        {
            // Check the file exists before trying to read it.
            if (!File.Exists(QuestionPath))
            {
                throw new FileNotFoundException($"The questions file was not found: {QuestionPath}");
            }

            string json = File.ReadAllText(QuestionPath);
            List<Question> questions = JsonSerializer.Deserialize<List<Question>>(json);

            // Check that the questions file isn't empty (null).
            if (questions == null)
            {
                throw new Exception("The questions file is empty.");
            }

            foreach (Question question in questions)
            {
                question.Text = WebUtility.HtmlDecode(question.Text);
                question.CorrectAnswer = WebUtility.HtmlDecode(question.CorrectAnswer);
                question.IncorrectAnswers = question.IncorrectAnswers.Select(answer => WebUtility.HtmlDecode(answer).Trim()).ToList();
            }

            return questions;
        }
    }
}
