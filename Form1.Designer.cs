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
            answerALabel = new Button();
            answerBLabel = new Button();
            answerCLabel = new Button();
            answerDLabel = new Button();
            playerLabel = new Label();
            levelLabel = new Label();
            playingForLabel = new Label();
            friendLabel = new Label();
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
            questionLabel.AutoSize = true;
            questionLabel.BackColor = SystemColors.Window;
            questionLabel.BorderStyle = BorderStyle.FixedSingle;
            questionLabel.Location = new Point(218, 150);
            questionLabel.Name = "questionLabel";
            questionLabel.Padding = new Padding(100, 50, 100, 50);
            questionLabel.Size = new Size(266, 117);
            questionLabel.TabIndex = 2;
            questionLabel.Text = "QUESTION";
            // 
            // answerALabel
            // 
            answerALabel.Location = new Point(218, 388);
            answerALabel.Name = "answerALabel";
            answerALabel.Size = new Size(75, 23);
            answerALabel.TabIndex = 3;
            answerALabel.Text = "button1";
            answerALabel.UseVisualStyleBackColor = true;
            // 
            // answerBLabel
            // 
            answerBLabel.Location = new Point(367, 388);
            answerBLabel.Name = "answerBLabel";
            answerBLabel.Size = new Size(75, 23);
            answerBLabel.TabIndex = 4;
            answerBLabel.Text = "button2";
            answerBLabel.UseVisualStyleBackColor = true;
            // 
            // answerCLabel
            // 
            answerCLabel.Location = new Point(218, 481);
            answerCLabel.Name = "answerCLabel";
            answerCLabel.Size = new Size(75, 23);
            answerCLabel.TabIndex = 5;
            answerCLabel.Text = "button3";
            answerCLabel.UseVisualStyleBackColor = true;
            // 
            // answerDLabel
            // 
            answerDLabel.Location = new Point(367, 481);
            answerDLabel.Name = "answerDLabel";
            answerDLabel.Size = new Size(75, 23);
            answerDLabel.TabIndex = 6;
            answerDLabel.Text = "button4";
            answerDLabel.UseVisualStyleBackColor = true;
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
            // friendLabel
            // 
            friendLabel.AutoSize = true;
            friendLabel.Location = new Point(218, 24);
            friendLabel.Name = "friendLabel";
            friendLabel.Size = new Size(89, 15);
            friendLabel.TabIndex = 10;
            friendLabel.Text = "Phone a Friend:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(friendLabel);
            Controls.Add(playingForLabel);
            Controls.Add(levelLabel);
            Controls.Add(playerLabel);
            Controls.Add(answerDLabel);
            Controls.Add(answerCLabel);
            Controls.Add(answerBLabel);
            Controls.Add(answerALabel);
            Controls.Add(questionLabel);
            Controls.Add(moneyTreeTitle);
            Controls.Add(moneyTree);
            Name = "Form1";
            Text = "Who Wants To Be A Millionare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox moneyTree;
        private Label moneyTreeTitle;
        private Label questionLabel;
        private Button answerALabel;
        private Button answerBLabel;
        private Button answerCLabel;
        private Button answerDLabel;
        private Label playerLabel;
        private Label levelLabel;
        private Label playingForLabel;
        private Label friendLabel;
    }
}
