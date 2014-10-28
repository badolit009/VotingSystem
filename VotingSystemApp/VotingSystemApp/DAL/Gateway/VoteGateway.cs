using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApp.DAL.Gateway
{
    class VoteGateway:Gateway
    {
        public int GetVoterId(string email)
        {
           connection.Open();
            query = "SELECT * FROM t_Voter";
            command = new SqlCommand(query,connection);
            SqlDataReader aReader = command.ExecuteReader();
            int VoterId = 0;
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    if (email==aReader[1].ToString())
                    {
                        VoterId = (int) aReader[0];
                    }
                }
            }
            connection.Close();
            return VoterId;
        }

        public void VoteCast(int voterId, int Candidateid)
        {
            connection.Open();
            query = "INSERT INTO t_Voting (VoterId,CandidateId) VALUES(@0,@1)";
            command = new SqlCommand(query,connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@0", voterId);
            command.Parameters.AddWithValue("@1", Candidateid);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
