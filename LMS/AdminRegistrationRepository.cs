using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_App.Models;
using System.Data.SqlClient;
using System.Configuration;
namespace LMS_App
{
    public class AdminRegistrationRepository : IAdminRegistrationRepository<AdminRegistration>
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader sqlDataReader;
        public bool DeleteAdminRegistration(AdminRegistration AdminRegistration)
        {
            throw new NotImplementedException();
        }

        public List<AdminRegistration> GetAllAdminRegistrationRepositorys()
        {
            throw new NotImplementedException();
        }

        public AdminRegistration GetAdminRegistration(int empId)
        {
            throw new NotImplementedException();
        }

        public bool SaveAdminRegistration(AdminRegistration AdminRegistration)
        {
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText= "insert into AdminRegistration values(" + AdminRegistration.email + ",'" + AdminRegistration.first_name + "','" + AdminRegistration.last_name + "','" + AdminRegistration.AdminPassword + "')";
                if (sqlConnection.State ==System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                sqlCommand.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool UpdateAdminRegistration(AdminRegistration AdminRegistrationRepository)
        {
            throw new NotImplementedException();
        }
    }
}
