using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hagasha1
{
    public partial class RememberTheNumbers : Form
    {
        public RememberTheNumbers()
        {
            InitializeComponent();
        }

        Random generator = new Random();
        const int upperBoundOfRandom = 100;
        Stopwatch sw = new Stopwatch();

        private void RememberTheNumbers_Load(object sender, EventArgs e)
        {
            FirstLbl.Text = generator.Next(1, upperBoundOfRandom + 1).ToString();
            SecondLbl.Text = generator.Next(1, upperBoundOfRandom + 1).ToString();
            ThirdLbl.Text = generator.Next(1, upperBoundOfRandom + 1).ToString();
            FourthLbl.Text = generator.Next(1, upperBoundOfRandom + 1).ToString();
            FifthLbl.Text = generator.Next(1, upperBoundOfRandom + 1).ToString();

            FirstTxtBox.Enabled = false;
            SecondTxtBox.Enabled = false;
            ThirdTxtBox.Enabled = false;
            FourthTxtBox.Enabled = false;
            FifthTxtBox.Enabled = false;

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            FirstLbl.Visible = false;
            SecondLbl.Visible = false;
            ThirdLbl.Visible = false;
            FourthLbl.Visible = false;
            FifthLbl.Visible = false;

            FirstTxtBox.Enabled = true;
            SecondTxtBox.Enabled = true;
            ThirdTxtBox.Enabled = true;
            FourthTxtBox.Enabled = true;
            FifthTxtBox.Enabled = true;

            FirstListBox.Items.Clear();

            //sw.Stop();
            sw.Start();

        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            int scoreForRound = 0;
           

            if (FirstLbl.Text == FirstTxtBox.Text)
            {
                scoreForRound++;
            }
            else
            {
                FirstTxtBox.ForeColor = Color.Red;
            }

            if (SecondLbl.Text == SecondTxtBox.Text)
            {
                scoreForRound++;
            }
            else
            {
                SecondTxtBox.ForeColor = Color.Red;
            }

            if (ThirdLbl.Text == ThirdTxtBox.Text)
            {
                scoreForRound++;
            }
            else
            {
                ThirdTxtBox.ForeColor = Color.Red;
            }

            if (FourthLbl.Text == FourthTxtBox.Text)
            {
                scoreForRound++;
            }
            else
            {
                FourthTxtBox.ForeColor = Color.Red;
            }

            if (FifthLbl.Text == FifthTxtBox.Text)
            {
                scoreForRound++;
            }
            else
            {
                FifthTxtBox.ForeColor = Color.Red;
            }

            FirstListBox.Items.Add(scoreForRound);


            if (FirstLbl.Text == FirstTxtBox.Text && SecondLbl.Text == SecondTxtBox.Text && ThirdLbl.Text == ThirdTxtBox.Text && FourthLbl.Text == FourthTxtBox.Text && FifthLbl.Text == FifthTxtBox.Text)
            {
                MessageBox.Show($"You won 100% ! And it took you only { sw.ElapsedMilliseconds/1000.0} seconds!");
            }

            else
            {
                MessageBox.Show($"Your score is {scoreForRound}! It took you {sw.ElapsedMilliseconds/1000.0} seconds! Try again!");
            }
            sw.Stop();


        }


        //new game
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstLbl.Text = generator.Next(1, upperBoundOfRandom + 1).ToString();
            SecondLbl.Text = generator.Next(1, upperBoundOfRandom + 1).ToString();
            ThirdLbl.Text = generator.Next(1, upperBoundOfRandom + 1).ToString();
            FourthLbl.Text = generator.Next(1, upperBoundOfRandom + 1).ToString();
            FifthLbl.Text = generator.Next(1, upperBoundOfRandom + 1).ToString();

            FirstListBox.Items.Clear();
            
            FirstTxtBox.Clear();
            SecondTxtBox.Clear();
            ThirdTxtBox.Clear();
            FourthTxtBox.Clear();
            FifthTxtBox.Clear();
        }

        //exit game
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Are you sure you want to leave?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
