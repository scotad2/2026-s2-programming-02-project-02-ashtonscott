namespace WinFormsApp1
{
    partial class Form1
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
            moneyTree = new ListBox();
            moneyTreeTitle = new Label();
            questionLabel = new Label();
            answerAButton = new Button();
            answerBButton = new Button();
            answerCButton = new Button();
            answerDButton = new Button();
            playerLabel = new Label();
            levelLabel = new Label();
            playingForLabel = new Label();
            scoreLabel = new Label();
            friendLabel = new Label();
            categoryCombo = new ComboBox();
            chooseCategoryButton = new Button();
            walkAwayButton = new Button();
            fiftyFiftyButton = new Button();
            audienceButton = new Button();
            phoneButton = new Button();
            changeQuestionButton = new Button();
            SuspendLayout();
            // 
            // moneyTree
            // 
            moneyTree.FormattingEnabled = true;
            moneyTree.ItemHeight = 15;
            moneyTree.Location = new Point(722, 150);
            moneyTree.Name = "moneyTree";
            moneyTree.Size = new Size(250, 499);
            moneyTree.TabIndex = 0;
            moneyTree.SelectedIndexChanged += MoneyTree_SelectedIndexChanged;
            // 
            // moneyTreeTitle
            // 
            moneyTreeTitle.AutoSize = true;
            moneyTreeTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moneyTreeTitle.Location = new Point(722, 117);
            moneyTreeTitle.Name = "moneyTreeTitle";
            moneyTreeTitle.Size = new Size(91, 20);
            moneyTreeTitle.TabIndex = 1;
            moneyTreeTitle.Text = "Money Tree";
            // 
            // questionLabel
            // 
            questionLabel.BackColor = SystemColors.Window;
            questionLabel.BorderStyle = BorderStyle.FixedSingle;
            questionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionLabel.Location = new Point(30, 150);
            questionLabel.Name = "questionLabel";
            questionLabel.Padding = new Padding(10);
            questionLabel.Size = new Size(650, 150);
            questionLabel.TabIndex = 2;
            questionLabel.Text = "QUESTION";
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerAButton
            // 
            answerAButton.Location = new Point(30, 340);
            answerAButton.Name = "answerAButton";
            answerAButton.Size = new Size(320, 70);
            answerAButton.TabIndex = 3;
            answerAButton.UseVisualStyleBackColor = true;
            answerAButton.Click += AnswerButton_Click;
            // 
            // answerBButton
            // 
            answerBButton.Location = new Point(360, 340);
            answerBButton.Name = "answerBButton";
            answerBButton.Size = new Size(320, 70);
            answerBButton.TabIndex = 4;
            answerBButton.UseVisualStyleBackColor = true;
            answerBButton.Click += AnswerButton_Click;
            // 
            // answerCButton
            // 
            answerCButton.Location = new Point(30, 430);
            answerCButton.Name = "answerCButton";
            answerCButton.Size = new Size(320, 70);
            answerCButton.TabIndex = 5;
            answerCButton.UseVisualStyleBackColor = true;
            answerCButton.Click += AnswerButton_Click;
            // 
            // answerDButton
            // 
            answerDButton.Location = new Point(360, 430);
            answerDButton.Name = "answerDButton";
            answerDButton.Size = new Size(320, 70);
            answerDButton.TabIndex = 6;
            answerDButton.UseVisualStyleBackColor = true;
            answerDButton.Click += AnswerButton_Click;
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Location = new Point(12, 24);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(42, 15);
            playerLabel.TabIndex = 7;
            playerLabel.Text = "Player:";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new Point(12, 58);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(37, 15);
            levelLabel.TabIndex = 8;
            levelLabel.Text = "Level:";
            // 
            // playingForLabel
            // 
            playingForLabel.AutoSize = true;
            playingForLabel.Location = new Point(218, 58);
            playingForLabel.Name = "playingForLabel";
            playingForLabel.Size = new Size(67, 15);
            playingForLabel.TabIndex = 9;
            playingForLabel.Text = "Playing for:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(450, 58);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(39, 15);
            scoreLabel.TabIndex = 10;
            scoreLabel.Text = "Score:";
            // 
            // friendLabel
            // 
            friendLabel.AutoSize = true;
            friendLabel.Location = new Point(218, 24);
            friendLabel.Name = "friendLabel";
            friendLabel.Size = new Size(89, 15);
            friendLabel.TabIndex = 11;
            friendLabel.Text = "Phone a Friend:";
            // 
            // categoryCombo
            // 
            categoryCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryCombo.FormattingEnabled = true;
            categoryCombo.Location = new Point(30, 100);
            categoryCombo.Name = "categoryCombo";
            categoryCombo.Size = new Size(250, 23);
            categoryCombo.TabIndex = 12;
            // 
            // chooseCategoryButton
            // 
            chooseCategoryButton.Location = new Point(290, 99);
            chooseCategoryButton.Name = "chooseCategoryButton";
            chooseCategoryButton.Size = new Size(150, 25);
            chooseCategoryButton.TabIndex = 13;
            chooseCategoryButton.Text = "Choose Category";
            chooseCategoryButton.UseVisualStyleBackColor = true;
            chooseCategoryButton.Click += ChooseCategoryButton_Click;
            // 
            // walkAwayButton
            // 
            walkAwayButton.Location = new Point(30, 585);
            walkAwayButton.Name = "walkAwayButton";
            walkAwayButton.Size = new Size(150, 40);
            walkAwayButton.TabIndex = 14;
            walkAwayButton.Text = "Walk Away";
            walkAwayButton.UseVisualStyleBackColor = true;
            walkAwayButton.Click += WalkAwayButton_Click;
            // 
            // fiftyFiftyButton
            // 
            fiftyFiftyButton.Enabled = false;
            fiftyFiftyButton.Location = new Point(30, 520);
            fiftyFiftyButton.Name = "fiftyFiftyButton";
            fiftyFiftyButton.Size = new Size(150, 45);
            fiftyFiftyButton.TabIndex = 15;
            fiftyFiftyButton.Text = "50:50";
            fiftyFiftyButton.UseVisualStyleBackColor = true;
            // 
            // audienceButton
            // 
            audienceButton.Enabled = false;
            audienceButton.Location = new Point(190, 520);
            audienceButton.Name = "audienceButton";
            audienceButton.Size = new Size(150, 45);
            audienceButton.TabIndex = 16;
            audienceButton.Text = "Ask the Audience";
            audienceButton.UseVisualStyleBackColor = true;
            // 
            // phoneButton
            // 
            phoneButton.Enabled = false;
            phoneButton.Location = new Point(350, 520);
            phoneButton.Name = "phoneButton";
            phoneButton.Size = new Size(150, 45);
            phoneButton.TabIndex = 17;
            phoneButton.Text = "Phone a Friend";
            phoneButton.UseVisualStyleBackColor = true;
            // 
            // changeQuestionButton
            // 
            changeQuestionButton.Enabled = false;
            changeQuestionButton.Location = new Point(510, 520);
            changeQuestionButton.Name = "changeQuestionButton";
            changeQuestionButton.Size = new Size(150, 45);
            changeQuestionButton.TabIndex = 18;
            changeQuestionButton.Text = "Change the Question";
            changeQuestionButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(changeQuestionButton);
            Controls.Add(phoneButton);
            Controls.Add(audienceButton);
            Controls.Add(fiftyFiftyButton);
            Controls.Add(walkAwayButton);
            Controls.Add(chooseCategoryButton);
            Controls.Add(categoryCombo);
            Controls.Add(scoreLabel);
            Controls.Add(friendLabel);
            Controls.Add(playingForLabel);
            Controls.Add(levelLabel);
            Controls.Add(playerLabel);
            Controls.Add(answerDButton);
            Controls.Add(answerCButton);
            Controls.Add(answerBButton);
            Controls.Add(answerAButton);
            Controls.Add(questionLabel);
            Controls.Add(moneyTreeTitle);
            Controls.Add(moneyTree);
            Name = "Form1";
            Text = "Who Wants To Be A Millionaire";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox moneyTree;
        private Label moneyTreeTitle;
        private Label questionLabel;
        private Button answerAButton;
        private Button answerBButton;
        private Button answerCButton;
        private Button answerDButton;
        private Label playerLabel;
        private Label levelLabel;
        private Label playingForLabel;
        private Label scoreLabel;
        private Label friendLabel;
        private ComboBox categoryCombo;
        private Button chooseCategoryButton;
        private Button walkAwayButton;
        private Button fiftyFiftyButton;
        private Button audienceButton;
        private Button phoneButton;
        private Button changeQuestionButton;
    }
}