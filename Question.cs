using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// A single multiple-choice question from the JSON file.
    /// </summary>
    public class Question
    {
        /// <summary>The type of question, e.g. "multiple".</summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        /// <summary>The difficulty: easy, medium or hard.</summary>
        [JsonPropertyName("difficulty")]
        public string Difficulty { get; set; } = "";

        /// <summary>The topic of the question.</summary>
        [JsonPropertyName("category")]
        public string Category { get; set; } = "";

        /// <summary>The question text.</summary>
        [JsonPropertyName("question")]
        public string Text { get; set; } = "";

        /// <summary>The correct answer.</summary>
        [JsonPropertyName("correct_answer")]
        public string CorrectAnswer { get; set; } = "";

        /// <summary>The incorrect answers.</summary>
        [JsonPropertyName("incorrect_answers")]
        public List<string> IncorrectAnswers { get; set; } = new();
    }
}
