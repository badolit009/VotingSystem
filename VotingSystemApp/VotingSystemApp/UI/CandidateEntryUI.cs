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

namespace VotingSystemApp.UI
{
    public partial class CandidateEntryUI : Form
    {
        public CandidateEntryUI()
        {
            InitializeComponent();
        }

        private CandidateBLL aCandidateBll = new CandidateBLL();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Candidate aCandidate = new Candidate(nameTextBox.Text,symbolTextBox.Text);
            string msg;
            msg=aCandidateBll.Save(aCandidate);
            MessageBox.Show(msg);

        }
    }
}
