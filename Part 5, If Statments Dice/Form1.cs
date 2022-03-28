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
        Random rand = new Random();
        int bet;
        int bankAccount;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            bankAccount = 100;
            int currentBet;
            if (Int32.TryParse(txtBet.Text, out currentBet))
            {
                if (bet <= bankAccount)
                {



                    

                }
            }


        }
    }
}
