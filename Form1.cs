using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Your_Weight_on_Mars
{
    public partial class Form1 : Form
    {
        // Constant Fields
        private const double earthSurfaceGravity = 1.0;
        private const double marsSurfaceGravity = 0.38;
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double earthWeight; // To hold earth weight
                double marsWeight; // To hold mars weight

                // Get the weight of earth
                earthWeight = double.Parse(earthWeightTextBox.Text);


                // calculate the conversion 
                marsWeight = earthWeight * marsSurfaceGravity;

                // Display mars weight with the output rounded to 3 decimal
                marsWeightLabel.Text = marsWeight.ToString("n3");


            }
            catch (Exception ex)
            {
                // Display the deafault error
                MessageBox.Show(ex.Message);
            }
        }
    }
}
