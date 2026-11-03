namespace WinFormsApp1
{
    /// <summary>
    /// Shows the final score with Play Again and Exit buttons. It has no close button.
    /// </summary>
    public partial class GameOverForm : Form
    {
        /// <summary>
        /// Creates the form and shows the final score.
        /// </summary>
        /// <param name="finalScore">The amount the player won.</param>
        public GameOverForm(int finalScore)
        {
            InitializeComponent();
            finalScoreLabel.Text = $"You won ${finalScore:N0}";
        }
    }
}