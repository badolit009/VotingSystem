using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApp.DAL.DAO
{
    class Voter
    {
        public int VoterId { get; set; }
        public int CandidateId { get; set; }
        public string Email { get; set; }

        public Voter(string email):this()
        {
            Email = email;
        }

        public Voter()
        {
        }
    }
}
