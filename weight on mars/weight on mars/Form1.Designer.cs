
namespace weight_on_mars
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
            this.exitButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.yourWeightLabel = new System.Windows.Forms.Label();
            this.humanWeightTextBox = new System.Windows.Forms.TextBox();
            this.weightOnMarsLabel = new System.Windows.Forms.Label();
            this.weightOnMarsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Location = new System.Drawing.Point(1121, 459);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(171, 61);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.convertButton.Location = new System.Drawing.Point(128, 459);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(178, 61);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // yourWeightLabel
            // 
            this.yourWeightLabel.AutoSize = true;
            this.yourWeightLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yourWeightLabel.Location = new System.Drawing.Point(63, 143);
            this.yourWeightLabel.Name = "yourWeightLabel";
            this.yourWeightLabel.Size = new System.Drawing.Size(243, 42);
            this.yourWeightLabel.TabIndex = 2;
            this.yourWeightLabel.Text = "Your Weight: ";
            // 
            // humanWeightTextBox
            // 
            this.humanWeightTextBox.Location = new System.Drawing.Point(1056, 143);
            this.humanWeightTextBox.Name = "humanWeightTextBox";
            this.humanWeightTextBox.Size = new System.Drawing.Size(387, 49);
            this.humanWeightTextBox.TabIndex = 3;
            // 
            // weightOnMarsLabel
            // 
            this.weightOnMarsLabel.AutoSize = true;
            this.weightOnMarsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weightOnMarsLabel.Location = new System.Drawing.Point(63, 267);
            this.weightOnMarsLabel.Name = "weightOnMarsLabel";
            this.weightOnMarsLabel.Size = new System.Drawing.Size(396, 42);
            this.weightOnMarsLabel.TabIndex = 4;
            this.weightOnMarsLabel.Text = "Your Weight On Mars: ";
            // 
            // weightOnMarsTextBox
            // 
            this.weightOnMarsTextBox.Location = new System.Drawing.Point(1056, 264);
            this.weightOnMarsTextBox.Name = "weightOnMarsTextBox";
            this.weightOnMarsTextBox.Size = new System.Drawing.Size(387, 49);
            this.weightOnMarsTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = global::weight_on_mars.Properties.Resources.marvin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1477, 605);
            this.Controls.Add(this.weightOnMarsTextBox);
            this.Controls.Add(this.weightOnMarsLabel);
            this.Controls.Add(this.humanWeightTextBox);
            this.Controls.Add(this.yourWeightLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "Form1";
            this.Text = "Weight On Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label yourWeightLabel;
        private System.Windows.Forms.TextBox humanWeightTextBox;
        private System.Windows.Forms.Label weightOnMarsLabel;
        private System.Windows.Forms.TextBox weightOnMarsTextBox;
    }
}

