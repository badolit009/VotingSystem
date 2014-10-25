using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemApp.DAL.DAO;
using VotingSystemApp.DAL.Gateway;

namespace VotingSystemApp.BLL
{
    class CandidateBLL
    {
        private CandidateGateway aCandidateGateway = new CandidateGateway();
        public string Save(Candidate aCandidate)
        {
            return aCandidateGateway.Save(aCandidate);
        }

        public List<Candidate> ShowSymbol()
        {
           return  aCandidateGateway.ShowSymbol();
        }
    }
}
