using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// Loads the questions from the JSON file.
    /// </summary>
    public static class DataHandler
    {
        /// <summary>
        /// Reads the JSON file and decodes any HTML entities (e.g. &amp;quot;) in the text.
        /// </summary>
        /// <param name="filePath">Path to the JSON file.</param>
        /// <returns>All questions in the file.</returns>
        public static List<Question> LoadQuestions(string filePath)
        {
            string json = File.ReadAllText(filePath);
            List<Question> questions = JsonSerializer.Deserialize<List<Question>>(json) ?? new List<Question>();

            foreach (Question question in questions)
            {
                question.Text = WebUtility.HtmlDecode(question.Text);
                question.CorrectAnswer = WebUtility.HtmlDecode(question.CorrectAnswer);
                question.IncorrectAnswers = question.IncorrectAnswers
                    .Select(answer => WebUtility.HtmlDecode(answer).Trim())
                    .ToList();
            }

            return questions;
        }
    }
}
