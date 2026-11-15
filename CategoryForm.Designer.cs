namespace WinFormsApp1
{
    partial class CategoryForm
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
            promptLabel = new Label();
            categoryCombo = new ComboBox();
            chooseButton = new Button();
            SuspendLayout();
            // 
            // promptLabel
            // 
            promptLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            promptLabel.Location = new Point(20, 20);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(320, 50);
            promptLabel.TabIndex = 0;
            promptLabel.Text = "Choose a category";
            promptLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // categoryCombo
            // 
            categoryCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryCombo.FormattingEnabled = true;
            categoryCombo.Location = new Point(55, 80);
            categoryCombo.Name = "categoryCombo";
            categoryCombo.Size = new Size(250, 23);
            categoryCombo.TabIndex = 1;
            // 
            // chooseButton
            // 
            chooseButton.DialogResult = DialogResult.OK;
            chooseButton.Location = new Point(105, 120);
            chooseButton.Name = "chooseButton";
            chooseButton.Size = new Size(150, 35);
            chooseButton.TabIndex = 2;
            chooseButton.Text = "Choose Category";
            chooseButton.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            AcceptButton = chooseButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 175);
            ControlBox = false;
            Controls.Add(chooseButton);
            Controls.Add(categoryCombo);
            Controls.Add(promptLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Choose a Category";
            ResumeLayout(false);
        }

        #endregion

        private Label promptLabel;
        private ComboBox categoryCombo;
        private Button chooseButton;
    }
}