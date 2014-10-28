using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemApp.BLL;
using VotingSystemApp.DAL.DAO;

namespace VotingSystemApp
{
    public partial class VoteCastUI : Form
    {
        
        public VoteCastUI()
        {
            InitializeComponent();
            GetSymbolComboBox();
        }

        private CandidateBLL aCandidateBll = new CandidateBLL();
        private VoteBLL aVoteBll = new VoteBLL();
        private void GetSymbolComboBox()
        {
            List<Candidate> aCandidates = aCandidateBll.ShowSymbol();
            foreach (Candidate aCandidate in aCandidates)
            voteSymbolComboBox.Items.Add(aCandidate);
            voteSymbolComboBox.DisplayMember = "Symbol";
            voteSymbolComboBox.ValueMember = "Id";


        }

        private void castButton_Click(object sender, EventArgs e)
        {
            Voter aVoter = new Voter(voteremailTextBox.Text);
            aVoter.VoterId = aVoteBll.GetVoterId(aVoter.Email);
            Candidate aCandidate = new Candidate();
            aCandidate = (Candidate) voteSymbolComboBox.SelectedItem;
            string msg = aVoteBll.VoteCast(aVoter.VoterId,aCandidate.CandidateId);
            MessageBox.Show(msg);

        }
        }
}
