namespace WinFormsApp1
{
    partial class GameOverForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameOverLabel = new Label();
            finalScoreLabel = new Label();
            playAgainButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // gameOverLabel
            // 
            gameOverLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameOverLabel.Location = new Point(23, 27);
            gameOverLabel.Name = "gameOverLabel";
            gameOverLabel.Size = new Size(343, 53);
            gameOverLabel.TabIndex = 0;
            gameOverLabel.Text = "Game Over";
            gameOverLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // finalScoreLabel
            // 
            finalScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalScoreLabel.Location = new Point(23, 93);
            finalScoreLabel.Name = "finalScoreLabel";
            finalScoreLabel.Size = new Size(343, 40);
            finalScoreLabel.TabIndex = 1;
            finalScoreLabel.Text = "You won $0";
            finalScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playAgainButton
            // 
            playAgainButton.DialogResult = DialogResult.Retry;
            playAgainButton.Location = new Point(46, 173);
            playAgainButton.Margin = new Padding(3, 4, 3, 4);
            playAgainButton.Name = "playAgainButton";
            playAgainButton.Size = new Size(126, 47);
            playAgainButton.TabIndex = 2;
            playAgainButton.Text = "Play Again";
            playAgainButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.DialogResult = DialogResult.Cancel;
            exitButton.Location = new Point(217, 173);
            exitButton.Margin = new Padding(3, 4, 3, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(126, 47);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 299);
            ControlBox = false;
            Controls.Add(exitButton);
            Controls.Add(playAgainButton);
            Controls.Add(finalScoreLabel);
            Controls.Add(gameOverLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GameOverForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Game Over";
            ResumeLayout(false);
        }

        #endregion

        private Label gameOverLabel;
        private Label finalScoreLabel;
        private Button playAgainButton;
        private Button exitButton;
    }
}