using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ContactsDataAccessLayer
{
    public class clsApplicationsData
    {
        public static DataTable GetAllApplications()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from ApplicationTypes";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
       
        public static bool GetApplicationTypeByID(int ApplicationID,ref string ApplicationType,ref decimal Fees )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    ApplicationType = (string)reader["ApplicationTypeTitle"];
                    Fees = (decimal)reader["ApplicationFees"];
                    

                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
       
        public static bool ChangeTypeAndFees(int ApplicationID,  string ApplicationType,  decimal Fees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "update ApplicationTypes set ApplicationTypeTitle=@ApplicationType , ApplicationFees=@Fees where ApplicationTypeID=@ApplicationTypeID ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationType", ApplicationType);
            command.Parameters.AddWithValue("@Fees", Fees);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isFound = true;
                }
                else
                {
                    isFound = false;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it)
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        
    }
}
