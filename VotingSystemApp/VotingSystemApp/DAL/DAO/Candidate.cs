using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApp.DAL.DAO
{
    class Candidate
    {
        private string p1;
        private string p2;

        public int Id  { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public Candidate(int id, string name, string symbol) : this()
        {
            Id = id;
            Name = name;
            Symbol = symbol;
        }

        public Candidate()
        {

        }

        public Candidate(string p1, string p2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
        }
    }

}
