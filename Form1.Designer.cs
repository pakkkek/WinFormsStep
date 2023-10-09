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
            guessButton = new Button();
            instructionLabel = new Label();
            guessTextBox = new TextBox();
            SuspendLayout();
            // 
            // guessButton
            // 
            guessButton.AccessibleName = "guessButton";
            guessButton.Location = new Point(223, 38);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(48, 23);
            guessButton.TabIndex = 1;
            guessButton.Text = "Try";
            guessButton.UseVisualStyleBackColor = true;
            guessButton.Click += guessButton_Click;
            // 
            // instructionLabel
            // 
            instructionLabel.AccessibleName = "instructionLabel";
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(29, 41);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(82, 15);
            instructionLabel.TabIndex = 2;
            instructionLabel.Text = "Enter number:";
            // 
            // guessTextBox
            // 
            guessTextBox.AccessibleName = "guessTextBox";
            guessTextBox.Location = new Point(117, 38);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(100, 23);
            guessTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 97);
            Controls.Add(guessTextBox);
            Controls.Add(instructionLabel);
            Controls.Add(guessButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button guessButton;
        private Label instructionLabel;
        private TextBox guessTextBox;
    }
}