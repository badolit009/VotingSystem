using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApp.DAL.DAO
{
    class Candidate
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int CandidateId { get; set; }

        public Candidate(string name, string symbol) : this()
        {
            Name = name;
            Symbol = symbol;
        }

        public Candidate()
        {

        }
    }

}
