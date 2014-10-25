using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemApp.UI;

namespace VotingSystemApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void candidateEntryButton_Click(object sender, EventArgs e)
        {
            CandidateEntryUI aCandidate=new CandidateEntryUI();
            aCandidate.ShowDialog();

        }

        private void noOfWinnerButton_Click(object sender, EventArgs e)
        {
            NoOfWinnersUI aNoOfWinnersUi = new NoOfWinnersUI();
            aNoOfWinnersUi.ShowDialog();


        }

        private void voteCastButton_Click(object sender, EventArgs e)
        {
            VoteCastUI aVoteCastUi = new VoteCastUI();
            aVoteCastUi.ShowDialog();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            ResultUI aResultUi = new ResultUI();
            aResultUi.ShowDialog();
        }
    }
}
