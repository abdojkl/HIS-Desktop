using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PatientRecordManagement.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using ServiceStack.OrmLite;
using static ServiceStack.Script.Lisp;

namespace PatientRecordManagement.Register
{
    internal class Chek_user
    {
        string Email_l;
        string Password_l;
        string roll;


        public String auth_chek(String Email, String password)
        {
            this.Email_l = Email;
            this.Password_l = password;

            string ConnectionString = "server=mysql5026.site4now.net;database=db_a9cd22_abdojkl;uid=a9cd22_abdojkl;password=a1234567;SslMode=None";



            // Establish connection to source database
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))

            {
                try
                {
                    connection.Open();
                    
                    string query = "SELECT * FROM users WHERE Email ='"+ Email + "' AND Password ='"+ password+"'";
                    // Create and execute the SELECT query
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                           if( reader.Read())
                            if(Email_l==reader.GetString("Email")  && Password_l == reader.GetString("Password"))
                            {
                                return reader.GetString("roll");
                            }

                    }    }

                }


                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }

            return null;
        }




    }


}   

    
