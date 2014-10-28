using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemApp.DAL.DAO;

namespace VotingSystemApp
{
    public partial class NoOfWinnersUI : Form
    {
        public NoOfWinnersUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            NoOfWinner aNoOfWinner = new NoOfWinner();
            aNoOfWinner.NoOfWinners = Convert.ToInt16(winnerTextBox.Text);
            MessageBox.Show("No Of Winners \t" +aNoOfWinner.NoOfWinners);
        }
    }
}
