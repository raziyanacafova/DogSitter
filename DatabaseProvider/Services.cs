using DogSitter.Models;
using DogSitter.Models.RequestModels;
using DogSitter.Models.ResponseModels;
using System.Data;
using System.Data.SqlClient;

namespace DogSitter.DatabaseProvider
{
    public static class Services
    {
        private static readonly string connectionstring = "Data Source=80.78.240.16;Initial Catalog=BakuDevEduBE.Group1;User ID=Student;Password=qwe!23;";

        public static void CreateSitter(RequestSitter sitter)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                using (SqlCommand command = new SqlCommand("CreateSitter", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstname", sitter.FirstName);
                    command.Parameters.AddWithValue("@lastname", sitter.LastName);
                    connection.Open();
                    command.ExecuteNonQuery();

                }

                //using (SqlConnection con = new SqlConnection(dc.Con))
                //{
                //    using (SqlCommand cmd = new SqlCommand("SP_ADD", con))
                //    {
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                //        cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                //        con.Open();
                //        cmd.ExecuteNonQuery();
                //    }
                //}
            }

        }
        public static void CreateClient(RequestClient client)
        {
            //Call to stored procedure to add a client with client.FirstName and client.LastName in Clients table
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                using (SqlCommand command = new SqlCommand("CreateClient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstname", client.FirstName);
                    command.Parameters.AddWithValue("@lastname", client.LastName);
                    connection.Open();
                    command.ExecuteNonQuery();

                }
            }
        }
        public static int GetSitterId(RequestSitter sitter )
        {
            int sitterid =0;//Call to stored procedure to get the id of the sitter with sitter.FirstName and sitter.LastName
            return sitterid;
        }
        public static int GetClientId(RequestClient client)
        {
            int clientid = 0;//Call to stored procedure to get the id of the client with client.FirstName and client.LastName
            return clientid;
        }
        public static int CreateHiring(int clientid,int sitterid)
        {
            //Call to s.p. to add a hiring with clientid and sitterid to the hirings table 
            int hireid = 0;//Call to s.p. to get the if od the last added hire in hirings table
            return hireid;
        }
        public static void CreateHiringDetails(ResponseHiring hiring)
        {
            
            //Call to s.p to create a hiringdetail with given arguments in hiringdetails table
        }
        public static void CreateFeedback(ResponseFeedback responsefeedback)
        {
            //Call to s.p. to add a new feedback with responsefeedback.SitterId, responsefeedback.SitterId,responsefeedback.Feedback

        }
    }
    }

