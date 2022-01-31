
namespace Activity_5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.saveStatsToNewFileButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.statisticsTextBox = new System.Windows.Forms.TextBox();
            this.firstAlphabeticalWord = new System.Windows.Forms.TextBox();
            this.lastAlphabeticalWord = new System.Windows.Forms.TextBox();
            this.longestWord = new System.Windows.Forms.TextBox();
            this.mostVowels = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(147, 506);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(226, 84);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "choose file ";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // saveStatsToNewFileButton
            // 
            this.saveStatsToNewFileButton.Location = new System.Drawing.Point(668, 506);
            this.saveStatsToNewFileButton.Name = "saveStatsToNewFileButton";
            this.saveStatsToNewFileButton.Size = new System.Drawing.Size(207, 91);
            this.saveStatsToNewFileButton.TabIndex = 1;
            this.saveStatsToNewFileButton.Text = "Save to new file";
            this.saveStatsToNewFileButton.UseVisualStyleBackColor = true;
            this.saveStatsToNewFileButton.Click += new System.EventHandler(this.saveStatsToNewFileButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1137, 503);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(207, 91);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(439, 38);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(644, 112);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Activity 5 Results ";
            // 
            // statisticsTextBox
            // 
            this.statisticsTextBox.Location = new System.Drawing.Point(458, 204);
            this.statisticsTextBox.Name = "statisticsTextBox";
            this.statisticsTextBox.Size = new System.Drawing.Size(569, 20);
            this.statisticsTextBox.TabIndex = 4;
            // 
            // firstAlphabeticalWord
            // 
            this.firstAlphabeticalWord.Location = new System.Drawing.Point(458, 245);
            this.firstAlphabeticalWord.Name = "firstAlphabeticalWord";
            this.firstAlphabeticalWord.Size = new System.Drawing.Size(569, 20);
            this.firstAlphabeticalWord.TabIndex = 5;
            // 
            // lastAlphabeticalWord
            // 
            this.lastAlphabeticalWord.Location = new System.Drawing.Point(458, 280);
            this.lastAlphabeticalWord.Name = "lastAlphabeticalWord";
            this.lastAlphabeticalWord.Size = new System.Drawing.Size(569, 20);
            this.lastAlphabeticalWord.TabIndex = 6;
            // 
            // longestWord
            // 
            this.longestWord.Location = new System.Drawing.Point(458, 329);
            this.longestWord.Name = "longestWord";
            this.longestWord.Size = new System.Drawing.Size(569, 20);
            this.longestWord.TabIndex = 7;
            // 
            // mostVowels
            // 
            this.mostVowels.Location = new System.Drawing.Point(458, 390);
            this.mostVowels.Name = "mostVowels";
            this.mostVowels.Size = new System.Drawing.Size(569, 20);
            this.mostVowels.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 633);
            this.Controls.Add(this.mostVowels);
            this.Controls.Add(this.longestWord);
            this.Controls.Add(this.lastAlphabeticalWord);
            this.Controls.Add(this.firstAlphabeticalWord);
            this.Controls.Add(this.statisticsTextBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveStatsToNewFileButton);
            this.Controls.Add(this.chooseFileButton);
            this.Name = "Form1";
            this.Text = "Activity 5 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Button saveStatsToNewFileButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox statisticsTextBox;
        private System.Windows.Forms.TextBox firstAlphabeticalWord;
        private System.Windows.Forms.TextBox lastAlphabeticalWord;
        private System.Windows.Forms.TextBox longestWord;
        private System.Windows.Forms.TextBox mostVowels;
    }
}

