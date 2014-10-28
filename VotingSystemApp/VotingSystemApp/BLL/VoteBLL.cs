using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemApp.DAL.Gateway;

namespace VotingSystemApp.BLL
{
    class VoteBLL
    {
        private VoteGateway aVoteGateway = new VoteGateway();
        public int GetVoterId(string email)
        {
            return aVoteGateway.GetVoterId(email);
        }

        public string VoteCast(int voterId, int CandidateId)
        {
             aVoteGateway.VoteCast(voterId,CandidateId);
            return "Vote has been casted";
        }
    }
}
