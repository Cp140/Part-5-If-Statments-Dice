using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_5__If_Statments_Dice
{
    public partial class frmMain : Form
    {
        //Random generator
        Random rnd = new Random();

        //Variables
        double bet;
        double bankAccount = 100;
        double die1;
        double die2;
        double currentBet;
        bool doubles = false;
        bool notDoubles = false;
        bool evenSum = false;
        bool oddSum = false;

        public frmMain()
        {
            InitializeComponent();
        }
        // dice roll function---------------------
        public void Roll()
        {
            die1 = rnd.Next(1, 7);
            die2 = rnd.Next(1, 7);
            switch (die1)
            {
                //displays dice
                case 1:
                    imgDie1.Image = Properties.Resources.die_1;
                    break;
                case 2:
                    imgDie1.Image = Properties.Resources.die_2;
                    break;
                case 3:
                    imgDie1.Image = Properties.Resources.die_3;
                    break;
                case 4:
                    imgDie1.Image = Properties.Resources.die_4;
                    break;
                case 5:
                    imgDie1.Image = Properties.Resources.die_5;
                    break;
                case 6:
                    imgDie1.Image = Properties.Resources.die_6;
                    break;
            }
            switch (die2)
            {
                //displays dice
                case 1:
                    imgDie2.Image = Properties.Resources.die_1;
                    break;
                case 2:
                    imgDie2.Image = Properties.Resources.die_2;
                    break;
                case 3:
                    imgDie2.Image = Properties.Resources.die_3;
                    break;
                case 4:
                    imgDie2.Image = Properties.Resources.die_4;
                    break;
                case 5:
                    imgDie2.Image = Properties.Resources.die_5;
                    break;
                case 6:
                    imgDie2.Image = Properties.Resources.die_6;
                    break;
            }   
        }
        private void btnBet_Click(object sender, EventArgs e)
        {
            //Roll dice function
            Roll();
            if (double.TryParse(txtBet.Text, out currentBet))
            {
                //checks if bet is smaller that bankaccount
                if (currentBet <= bankAccount)
                {              

                    //checks for bet placed on and if won
                    if (doubles == true && die1 == die2)
                    {
                        bankAccount = bankAccount + (currentBet * 2);
                        txtBank.Text = ($"{bankAccount}");
                    }
                    else if (notDoubles == true && die1 != die2)
                    {
                        bankAccount = bankAccount + (currentBet * 1.5);
                        txtBank.Text = ($"{bankAccount}");
                    }
                    else if (evenSum == true && ((die1 + die2) % 2 == 0))
                    {
                        bankAccount = bankAccount + currentBet;
                        txtBank.Text = ($"{bankAccount}");
                    }
                    else if (oddSum == true && ((die1 + die2) % 2 == 1))
                    {
                        bankAccount = bankAccount + currentBet;
                        txtBank.Text = ($"{bankAccount}");
                    }
                    else
                    {
                        bankAccount = bankAccount - currentBet;
                        txtBank.Text = ($"{bankAccount}");
                    }
                }
                else
                {
                }
            } 
        }
        //selected beting choice
        private void btnDoubles_Click(object sender, EventArgs e)
        {
            doubles = true;
            notDoubles = false;
            evenSum = false;
            oddSum = false;
        }
        private void btnNotDouble_Click(object sender, EventArgs e)
        {
            doubles = false;
            notDoubles = true;
            evenSum = false;
            oddSum = false;
        }
        private void btnEvenSum_Click(object sender, EventArgs e)
        {
            doubles = false;
            notDoubles = false;
            evenSum = true;
            oddSum = false;
        }
        private void btnOddSum_Click(object sender, EventArgs e)
        {
            doubles = false;
            notDoubles = false;
            evenSum = false;
            oddSum = true;
        }
    }
}
