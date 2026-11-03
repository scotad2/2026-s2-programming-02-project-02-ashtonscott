namespace WinFormsApp1
{
    /// <summary>
    /// The main game form: shows the question, answers, score and money tree and runs the game.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>Prize for each level, lowest first. Levels 5 and 10 are the bank levels.</summary>
        private static readonly int[] Prizes =
        {
            100, 200, 300, 500, 1000, 2000, 4000, 8000, 16000, 32000,
            64000, 125000, 250000, 500000, 1000000
        };

        /// <summary>The categories exactly as they appear in the JSON file.</summary>
        private static readonly string[] Categories =
        {
            "Sports", "Entertainment: Music", "Art", "General Knowledge", "Science: Computers", "History"
        };

        /// <summary>Difficulty of each stage of the game: easy, then medium, then hard.</summary>
        private static readonly string[] Difficulties = { "easy", "medium", "hard" };

        /// <summary>How many questions each stage (difficulty) lasts.</summary>
        private const int LevelsPerStage = 5;

        private readonly Player _player = new("Alex", 21, new List<string> { "Gaming", "Football" }, "Student");
        private readonly Random _random = new();
        private readonly Button[] _answerButtons;

        private QuestionBank _questionBank = null!;
        private Question _currentQuestion = null!;
        private string _currentCategory = "";
        private int _level;
        private bool _acceptingAnswers;

        /// <summary>
        /// Sets up the form and groups the answer buttons so they can be handled together.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            _answerButtons = new[] { answerAButton, answerBButton, answerCButton, answerDButton };
        }

        /// <summary>
        /// Fills the money tree once, then starts the first game.
        /// </summary>
        private void Form1_Load(object? sender, EventArgs e)
        {
            for (int i = Prizes.Length - 1; i >= 0; i--)
            {
                bool isBank = (i + 1) % LevelsPerStage == 0 && i < Prizes.Length - 1;
                moneyTree.Items.Add($"{i + 1,2}   ${Prizes[i]:N0}{(isBank ? "  (bank)" : "")}");
            }

            playerLabel.Text = $"Player: {_player.Name}";
            StartGame();
        }

        /// <summary>
        /// Resets everything for a new game and asks for the first category.
        /// </summary>
        private void StartGame()
        {
            _questionBank = new QuestionBank(DataHandler.LoadQuestions(DataHandler.QuestionPath));
            _level = 0;

            categoryCombo.Items.Clear();
            categoryCombo.Items.AddRange(Categories);

            ShowNextStep();
        }

        /// <summary>
        /// Moves to the next step: a category choice at the start of each stage, otherwise a question.
        /// </summary>
        private void ShowNextStep()
        {
            UpdateLabels();
            ClearAnswers();

            if (_level % LevelsPerStage == 0)
            {
                ShowCategoryPicker();
            }
            else
            {
                ShowQuestion();
            }
        }

        /// <summary>
        /// Updates the level, prize, score labels and highlights the current spot on the money tree.
        /// </summary>
        private void UpdateLabels()
        {
            levelLabel.Text = $"Level: {_level + 1} of {Prizes.Length}";
            playingForLabel.Text = $"Playing for: ${Prizes[_level]:N0}";
            scoreLabel.Text = $"Score: ${GetScore():N0}";
            moneyTree.SelectedIndex = Prizes.Length - 1 - _level;
            walkAwayButton.Enabled = _level > 0;
        }

        /// <summary>
        /// Works out what the player has won so far.
        /// </summary>
        /// <returns>The prize of the last question answered, or 0 at the start.</returns>
        private int GetScore()
        {
            return _level == 0 ? 0 : Prizes[_level - 1];
        }

        /// <summary>
        /// Resets the answer buttons to blank, default-coloured buttons.
        /// </summary>
        private void ClearAnswers()
        {
            foreach (Button button in _answerButtons)
            {
                button.Text = "";
                button.UseVisualStyleBackColor = true;
            }
        }

        /// <summary>
        /// Asks the player to pick a category. Categories already used are removed from the list.
        /// </summary>
        private void ShowCategoryPicker()
        {
            _acceptingAnswers = false;
            questionLabel.Text = $"Choose a category for the {Difficulties[_level / LevelsPerStage]} questions";
            categoryCombo.SelectedIndex = 0;
            categoryCombo.Enabled = true;
            chooseCategoryButton.Enabled = true;
        }

        /// <summary>
        /// Locks in the chosen category, removes it from the list and shows the first question.
        /// </summary>
        private void ChooseCategoryButton_Click(object? sender, EventArgs e)
        {
            _currentCategory = categoryCombo.Text;
            categoryCombo.Items.Remove(_currentCategory);
            categoryCombo.Enabled = false;
            chooseCategoryButton.Enabled = false;

            ShowQuestion();
        }

        /// <summary>
        /// Gets a random question for the current category and difficulty and shows it with shuffled answers.
        /// </summary>
        private void ShowQuestion()
        {
            _currentQuestion = _questionBank.GetRandomQuestion(_currentCategory, Difficulties[_level / LevelsPerStage])!;
            questionLabel.Text = _currentQuestion.Text;

            List<string> answers = _currentQuestion.IncorrectAnswers
                .Append(_currentQuestion.CorrectAnswer)
                .OrderBy(answer => _random.Next())
                .ToList();

            for (int i = 0; i < _answerButtons.Length; i++)
            {
                _answerButtons[i].Text = answers[i];
            }

            _acceptingAnswers = true;
        }

        /// <summary>
        /// Handles a click on any answer button: shows green/red, then moves on or ends the game.
        /// </summary>
        private async void AnswerButton_Click(object? sender, EventArgs e)
        {
            if (!_acceptingAnswers)
            {
                return;
            }

            _acceptingAnswers = false;
            walkAwayButton.Enabled = false;

            Button clicked = (Button)sender!;
            Button correctButton = _answerButtons.First(button => button.Text == _currentQuestion.CorrectAnswer);
            bool isCorrect = clicked == correctButton;

            // The correct answer always turns green; a wrong choice turns red.
            correctButton.BackColor = Color.LightGreen;
            if (!isCorrect)
            {
                clicked.BackColor = Color.Red;
            }

            await Task.Delay(1500);

            if (!isCorrect)
            {
                EndGame(GetBankedPrize());
                return;
            }

            _level++;
            if (_level == Prizes.Length)
            {
                EndGame(Prizes[^1]);
            }
            else
            {
                ShowNextStep();
            }
        }

        /// <summary>
        /// After a wrong answer the player keeps the last bank level they passed.
        /// </summary>
        /// <returns>0, the first bank prize or the second bank prize.</returns>
        private int GetBankedPrize()
        {
            return _level < LevelsPerStage ? 0 : Prizes[_level / LevelsPerStage * LevelsPerStage - 1];
        }

        /// <summary>
        /// Lets the player leave with the money they have won so far.
        /// </summary>
        private void WalkAwayButton_Click(object? sender, EventArgs e)
        {
            EndGame(GetScore());
        }

        /// <summary>
        /// Shows the game over form, then either starts a new game or closes the app.
        /// </summary>
        /// <param name="finalScore">The amount the player leaves with.</param>
        private void EndGame(int finalScore)
        {
            _acceptingAnswers = false;

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
            moneyTree.SelectedIndex = Prizes.Length - 1 - _level;
        }
    }
}