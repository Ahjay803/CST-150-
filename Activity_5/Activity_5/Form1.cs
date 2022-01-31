using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// Allen Atkins 
// CST 150-Activity 5
 // 7:47PM 01/30/22
 // this is my work
 //

namespace Activity_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            OpenFileDialog openFDA1 = new OpenFileDialog();
            openFDA1.ShowDialog();
            openFDA1.InitialDirectory = "c:\\";
            openFDA1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFDA1.FilterIndex = 2;
            openFDA1.RestoreDirectory = true;

            var word = File.ReadAllText(openFDA1.FileName).ToLower();
            if(openFDA1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if((stream = openFDA1.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            string[] text = word.Split(' ');
                            Array.Sort<string>(text);
                            statisticsTextBox.Text = ("All lower case sentence: "  + word);

                            foreach(string letters in text)
                            {
                                firstAlphabeticalWord.Text = text[0];
                                lastAlphabeticalWord.Text = text[text.Length - 1];

                            }

                            string longestWRD = text.OrderByDescending(s => s.Length).First();
                            longestWord.Text = "\r\n" + longestWRD;
                            mostVowels.Text += "\r\n" + longestWRD;
                            foreach(string letters in text)
                            {
                                string temp = null;
                                if(letters.Contains("a") || letters.Contains("e") || letters.Contains("i") || letters.Contains("o") || letters.Contains("u"))
                                {
                                    int total = 0;
                                    total++;
                                    int tempTotal = 0;
                                    if (tempTotal > total)
                                    {
                                        temp = letters;
                                    }
                                }

                                mostVowels.Text += temp;
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveStatsToNewFileButton_Click(object sender, EventArgs e)
        {
           using(StreamWriter objWriter = new StreamWriter("results.txt"))
            {
                objWriter.WriteLine(statisticsTextBox.Text);
                objWriter.WriteLine(firstAlphabeticalWord.Text);
                objWriter.WriteLine(lastAlphabeticalWord.Text);
                objWriter.WriteLine(longestWord.Text);
                objWriter.WriteLine(mostVowels.Text);
                MessageBox.Show("All files has been written to results.txt file");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
