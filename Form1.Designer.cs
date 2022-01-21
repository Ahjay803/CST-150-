
namespace Your_Weight_on_Mars
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
            this.earthWeightLabel = new System.Windows.Forms.Label();
            this.weightOnMarsLabel = new System.Windows.Forms.Label();
            this.earthWeightTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.marsWeightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // earthWeightLabel
            // 
            this.earthWeightLabel.AutoSize = true;
            this.earthWeightLabel.Location = new System.Drawing.Point(232, 72);
            this.earthWeightLabel.Name = "earthWeightLabel";
            this.earthWeightLabel.Size = new System.Drawing.Size(135, 13);
            this.earthWeightLabel.TabIndex = 0;
            this.earthWeightLabel.Text = "Enter your weight on Earth:";
            // 
            // weightOnMarsLabel
            // 
            this.weightOnMarsLabel.AutoSize = true;
            this.weightOnMarsLabel.Location = new System.Drawing.Point(232, 224);
            this.weightOnMarsLabel.Name = "weightOnMarsLabel";
            this.weightOnMarsLabel.Size = new System.Drawing.Size(107, 13);
            this.weightOnMarsLabel.TabIndex = 1;
            this.weightOnMarsLabel.Text = "Your Weight on Mars";
            // 
            // earthWeightTextBox
            // 
            this.earthWeightTextBox.Location = new System.Drawing.Point(541, 72);
            this.earthWeightTextBox.Name = "earthWeightTextBox";
            this.earthWeightTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.earthWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.earthWeightTextBox.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(566, 342);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // marsWeightLabel
            // 
            this.marsWeightLabel.AutoSize = true;
            this.marsWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marsWeightLabel.Location = new System.Drawing.Point(575, 224);
            this.marsWeightLabel.Name = "marsWeightLabel";
            this.marsWeightLabel.Size = new System.Drawing.Size(0, 24);
            this.marsWeightLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.marsWeightLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.earthWeightTextBox);
            this.Controls.Add(this.weightOnMarsLabel);
            this.Controls.Add(this.earthWeightLabel);
            this.Name = "Form1";
            this.Text = "Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label earthWeightLabel;
        private System.Windows.Forms.Label weightOnMarsLabel;
        private System.Windows.Forms.TextBox earthWeightTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label marsWeightLabel;
    }
}

