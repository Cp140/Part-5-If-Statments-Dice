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

        //Role picture call function
        public void Die_1()
        {
            imgDie1.Image = Properties.Resources.die_1;

        }
        public void Die_2()
        {
            imgDie1.Image = Properties.Resources.die_2;

        }
        public void Die_3()
        {
            imgDie1.Image = Properties.Resources.die_3;

        }
        public void Die_4()
        {
            imgDie1.Image = Properties.Resources.die_4;

        }
        public void Die_5()
        {
            imgDie1.Image = Properties.Resources.die_5;

        }
        public void Die_6()
        {
            imgDie1.Image = Properties.Resources.die_6;

        }



        // dice roll function
        public void Roll()
        {
            die1 = rnd.Next(1, 7);
            die2 = rnd.Next(1, 7);
            rtbDie1.Text = ($"{die1}");
            rtbDie2.Text = ($"{die2}");
        }



        private void btnBet_Click(object sender, EventArgs e)
        {
            
            


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
