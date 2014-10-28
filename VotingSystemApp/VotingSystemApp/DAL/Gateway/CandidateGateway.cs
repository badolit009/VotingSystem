using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemApp.DAL.DAO;

namespace VotingSystemApp.DAL.Gateway
{
    internal class CandidateGateway : Gateway
    {
        public string Save(Candidate aCandidate)
        {
            connection.Open();
            query = "INSERT INTO t_Candidate (Name,Symbol) VALUES(@0,@1)";
            command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@0", aCandidate.Name);
            command.Parameters.AddWithValue("@1", aCandidate.Symbol);
            int affectedrows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedrows > 0)
            {
                return "Candidate Insert Successfully";

            }
            return "Insert Fail";
        }

        public List<Candidate> ShowSymbol()
        {
            connection.Open();
            query = string.Format("SELECT * FROM t_Candidate");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Candidate> aCandidates = new List<Candidate>();
            bool HasRows = aReader.HasRows;
            if (HasRows)
            {
                while (aReader.Read())
                {
                    Candidate aCandidate = new Candidate();
                    aCandidate.Id = (int)aReader[0];
                    aCandidate.Name = aReader[1].ToString();
                    aCandidate.Symbol = aReader[2].ToString();
                    aCandidates.Add(aCandidate);

                }


            }
            connection.Close();
            return aCandidates;
        }
    }
}
