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
    class CandidateGateway
    {
        private SqlConnection connection;
        public CandidateGateway()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        }

        public string Save(Candidate aCandidate)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Candidate VALUES('{0}','{1}')",aCandidate.Name,aCandidate.Symbol);
            SqlCommand command = new SqlCommand(query,connection);
            int affectedrows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedrows>0)
            {
                return "Candidate Insert Successfully";
                
            }
            return "Insert Fail";
        }

        public List<Candidate> ShowSymbol()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Candidate");
            SqlCommand command = new SqlCommand(query,connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Candidate> aCandidates = new List<Candidate>();
            bool HasRows = aReader.HasRows;
            if (HasRows)
            {
                while (aReader.Read())
                {
                    Candidate aCandidate = new Candidate();
                    aCandidate.Id = (int) aReader[0];
                    aCandidate.Name = aReader[1].ToString();
                    aCandidate.Symbol = aReader[2].ToString();
                    aCandidates.Add(aCandidate);

                } 
            
                connection.Close();
            return aCandidates;
        }
    }
}
