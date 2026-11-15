namespace WinFormsApp1
{
    /// <summary>
    /// The main game form: shows the question, answers, score and money tree and runs the game.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>The categories exactly as they appear in the JSON file.</summary>
        private static readonly string[] Categories =
        {
            "Sports",
            "Entertainment: Music",
            "Art",
            "General Knowledge",
            "Science: Computers",
            "History"
        };

        /// <summary>The player taking part in the game.</summary>
        private readonly Player _player = new("Alex", 21, new List<string> { "Gaming", "Football" }, "Student");

        /// <summary>Tracks the player's level, prizes and difficulty.</summary>
        private readonly MoneyTree _moneyTree = new();

        /// <summary>Used to shuffle the answers.</summary>
        private readonly Random _random = new();

        /// <summary>The four answer buttons, grouped so they can be handled together.</summary>
        private readonly Button[] _answerButtons;

        /// <summary>The categories the player has not chosen yet in this game.</summary>
        private List<string> _availableCategories = new();

        /// <summary>The questions that have not been asked yet.</summary>
        private QuestionBank _questionBank = null!;

        /// <summary>The question currently on screen.</summary>
        private Question _currentQuestion = null!;

        /// <summary>The category chosen for the current stage.</summary>
        private string _currentCategory = "";

        /// <summary>Whether the player's last answer was correct.</summary>
        private bool _answeredCorrectly;

        /// <summary>
        /// Sets up the form and groups the answer buttons.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            _answerButtons = [answerAButton, answerBButton, answerCButton, answerDButton];
        }

        /// <summary>
        /// Fills the money tree list, then starts the first game once the form is on screen.
        /// </summary>
        private void Form1_Shown(object? sender, EventArgs e)
        {
            moneyTreeList.Items.AddRange(
            [
                "15.   $1,000,000",
                "14.   $500,000",
                "13.   $250,000",
                "12.   $125,000",
                "11.   $64,000",
                "10.   $32,000  (bank)",
                " 9.   $16,000",
                " 8.   $8,000",
                " 7.   $4,000",
                " 6.   $2,000",
                " 5.   $1,000  (bank)",
                " 4.   $500",
                " 3.   $300",
                " 2.   $200",
                " 1.   $100"
            ]);

            playerLabel.Text = $"Player: {_player.Name}";
            StartGame();
        }

        /// <summary>
        /// Resets everything for a new game.
        /// </summary>
        private void StartGame()
        {
            _questionBank = new QuestionBank(DataHandler.LoadQuestions(DataHandler.QuestionPath));
            _availableCategories = new List<string>(Categories);
            _moneyTree.Reset();

            ShowNextStep();
        }

        /// <summary>
        /// Updates the labels, then shows a category choice at the start of each stage, otherwise a question.
        /// </summary>
        private void ShowNextStep()
        {
            levelLabel.Text = $"Level: {_moneyTree.Level + 1} of {_moneyTree.LevelCount}";
            playingForLabel.Text = $"Playing for: ${_moneyTree.PlayingFor:N0}";
            scoreLabel.Text = $"Score: ${_moneyTree.Score:N0}";
            moneyTreeList.SelectedIndex = _moneyTree.LevelCount - 1 - _moneyTree.Level;
            walkAwayButton.Enabled = _moneyTree.Level > 0;

            if (_moneyTree.IsStageStart)
            {
                ChooseCategory();
            }

            ShowQuestion();
        }

        /// <summary>
        /// Opens the category form, then removes the chosen category so it can't be picked again.
        /// </summary>
        private void ChooseCategory()
        {
            questionLabel.Text = "Choosing a category...";

            foreach (Button button in _answerButtons)
            {
                button.Text = "";
                button.Enabled = false;
            }

            using CategoryForm categoryForm = new(_availableCategories, _moneyTree.Difficulty);
            categoryForm.ShowDialog(this);

            _currentCategory = categoryForm.SelectedCategory;
            _availableCategories.Remove(_currentCategory);
        }

        /// <summary>
        /// Gets a random question for the current category and difficulty and shows it with shuffled answers.
        /// </summary>
        private void ShowQuestion()
        {
            _currentQuestion = _questionBank.GetRandomQuestion(_currentCategory, _moneyTree.Difficulty)!;
            questionLabel.Text = _currentQuestion.Text;

            List<string> answers = _currentQuestion.IncorrectAnswers
                .Append(_currentQuestion.CorrectAnswer)
                .OrderBy(answer => _random.Next())
                .ToList();

            for (int i = 0; i < _answerButtons.Length; i++)
            {
                _answerButtons[i].Text = answers[i];
                _answerButtons[i].UseVisualStyleBackColor = true;
                _answerButtons[i].Enabled = true;
            }
        }

        /// <summary>
        /// Handles a click on any answer button: shows green/red, then waits for the Continue button.
        /// </summary>
        private void AnswerButton_Click(object? sender, EventArgs e)
        {
            Button clicked = (Button)sender!;
            Button correctButton = _answerButtons.First(button => button.Text == _currentQuestion.CorrectAnswer);
            _answeredCorrectly = clicked == correctButton;

            // The correct answer always turns green; a wrong choice turns red.
            correctButton.BackColor = Color.LightGreen;
            if (!_answeredCorrectly)
            {
                clicked.BackColor = Color.Red;
            }

            // Disabled buttons can't be clicked, so the player can't answer twice.
            foreach (Button button in _answerButtons)
            {
                button.Enabled = false;
            }

            walkAwayButton.Enabled = false;
            continueButton.Visible = true;
        }

        /// <summary>
        /// Moves on after an answer: ends the game if it was wrong or the last level, otherwise goes up a level.
        /// </summary>
        private void ContinueButton_Click(object? sender, EventArgs e)
        {
            continueButton.Visible = false;

            if (!_answeredCorrectly)
            {
                EndGame(_moneyTree.BankedPrize);
                return;
            }

            _moneyTree.Advance();
            if (_moneyTree.Level == _moneyTree.LevelCount)
            {
                EndGame(_moneyTree.Score);
            }
            else
            {
                ShowNextStep();
            }
        }

        /// <summary>
        /// Lets the player leave with the money they have won so far.
        /// </summary>
        private void WalkAwayButton_Click(object? sender, EventArgs e)
        {
            EndGame(_moneyTree.Score);
        }

        /// <summary>
        /// Shows the game over form, then either starts a new game or closes the app.
        /// </summary>
        /// <param name="finalScore">The amount the player leaves with.</param>
        private void EndGame(int finalScore)
        {
            using GameOverForm gameOver = new(finalScore);
            if (gameOver.ShowDialog(this) == DialogResult.Retry)
            {
                StartGame();
            }
            else
            {
                Close();
            }
        }

        /// <summary>
        /// Stops the player clicking a different row, so the highlight always shows the current level.
        /// </summary>
        private void MoneyTree_SelectedIndexChanged(object? sender, EventArgs e)
        {
            moneyTreeList.SelectedIndex = _moneyTree.LevelCount - 1 - _moneyTree.Level;
        }
    }
}