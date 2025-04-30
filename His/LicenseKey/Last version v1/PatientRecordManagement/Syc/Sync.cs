using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.OrmLite;
using ServiceStack;
using System.Windows.Forms.DataVisualization.Charting;

namespace PatientRecordManagement.Syc
{
    public partial class Sync : Form
    {
        public Sync()
        {
            InitializeComponent();
            var patients = Kt.Db.Select<Models.Patient>();
            var visits = Kt.Db.Select<Models.Visit>();
            all_pat_lb.Text = patients.Count().ToString("N0");
            all_vis_lb.Text = visits.Count().ToString("N0");
            unsyc_pat_lb.Text = patients.Where(r=> r.Syc == false).Count().ToString("N0");
            unsyc_vis_lb.Text = visits.Where(r => r.Syc == false).Count().ToString();

        }

        private void Syc_bt_Click(object sender, EventArgs e)

        {


            {
                if (unsyc_vis_lb.Text.ToInt() ==0 && unsyc_pat_lb.Text.ToInt()==0)
                {
                    MessageBox.Show("لايوجد بيانات تحتاج مزامنة");
                    return;
                   
                }

                    bunifuLoader1.Visible = true;
                string sourceConnectionString = "server = localhost; database = his; uid=root;password=;SslMode=None";
                string targetConnectionString = "server=mysql5048.site4now.net;database=db_a9cd22_abdojkl;uid=a9cd22_abdojkl;password=a3110342";

                string query1 = "SELECT * FROM Patients where Syc=0";
                string query2 = "SELECT * FROM visits where Syc=0";

                try
                {
                    // Establish connection to source database
                    using (MySqlConnection sourceConnection = new MySqlConnection(sourceConnectionString))
                    {
                        sourceConnection.Open();

                        // Create and execute the SELECT query
                        using (MySqlCommand command = new MySqlCommand(query1, sourceConnection))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                // Establish connection to target database
                                using (MySqlConnection targetConnection = new MySqlConnection(targetConnectionString))
                                {
                                    targetConnection.Open();

                                    // Loop through the rows returned by the query
                                    while (reader.Read())
                                    {
                                        // Assuming the target table has the same schema as the source table
                                        // You may need to adjust this if the schemas differ
                                        string Name = reader["Name"].ToString();
                                        string Gender = reader["Gender"].ToString();
                                        string prelocation = reader["prelocation"].ToString();
                                        string orglocation = reader["orglocation"].ToString();
                                        string Displacement = reader["Displacement"].ToString();
                                        string Status = reader["Status"].ToString();
                                        string Disability = reader["Disability"].ToString();
                                        string Bloodtype = reader["Bloodtype"].ToString();
                                        string DOB = reader["DOB"].ToString();
                                        string Phone = reader["Phone"].ToString();
                                        string B_G_M_W = reader["B_G_M_W"].ToString();
                                        string Syc = reader["Syc"].ToString();
                                        string CreatedAt = reader["CreatedAt"].ToString();

                                        // ...

                                        // Insert the row into the target database
                                        string insertQuery = $"INSERT INTO patients (Name, Gender,prelocation,orglocation,Displacement,Status,Disability,Bloodtype,DOB,Phone,B_G_M_W,Syc,CreatedAt) VALUES ('{Name}', '{Gender}', '{prelocation}', '{orglocation}', '{Displacement}', '{Status}', '{Disability}', '{Bloodtype}', '{DOB}', '{Phone}', '{B_G_M_W}', '{Syc}', '{CreatedAt}')";
                                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, targetConnection))
                                        {
                                            insertCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                       
                        bunifuProgressBar1.Value = 100;
                        bunifuCheckBox1.Visible = true;
                        //////////////////////////////////////////////////
                        using (MySqlCommand command = new MySqlCommand(query2, sourceConnection))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                // Establish connection to target database
                                using (MySqlConnection targetConnection = new MySqlConnection(targetConnectionString))
                                {
                                    targetConnection.Open();

                                    // Loop through the rows returned by the query
                                    while (reader.Read())
                                    {
                                        // Assuming the target table has the same schema as the source table
                                        // You may need to adjust this if the schemas differ
                                        string Type_of_service = reader["Type_of_service"].ToString();
                                        string Reason = reader["Reason"].ToString();
                                        string Diagnosis = reader["Diagnosis"].ToString();
                                        string TSerProvide = reader["TSerProvide"].ToString();
                                        string NSerProvide = reader["NSerProvide"].ToString();
                                        string Medicine = reader["Medicine"].ToString();
                                        string med_allergy = reader["med_allergy"].ToString();
                                        string Med_antecedents = reader["Med_antecedents"].ToString();
                                        string TestSCH = reader["TestSCH"].ToString();
                                        string ECG = reader["ECG"].ToString();
                                        string Date = reader["Date"].ToString();
                                        string Referral = reader["Referral"].ToString();
                                        string type_delivery = reader["type_delivery"].ToString();
                                        string Delivery_Complic = reader["Delivery_Complic"].ToString();
                                        string Num_of_bouys = reader["Num_of_bouys"].ToString();
                                        string Gender_of_bouy = reader["Gender_of_bouy"].ToString();
                                        string Weight_of_bouy = reader["Weight_of_bouy"].ToString();
                                        string BRM = reader["BRM"].ToString();
                                        string Death_Mother = reader["Death_Mother"].ToString();
                                        string Death_Bouy = reader["Death_Bouy"].ToString();
                                        string Referral_From = reader["Referral_From"].ToString();
                                        string Referral_To = reader["Referral_To"].ToString();
                                        string RH_Service = reader["RH_Service"].ToString();
                                        string PatientId = reader["Referral_From"].ToString();
                                        string DoctorId = reader["Referral_To"].ToString();
                                        string CreatedAt = reader["RH_Service"].ToString();
                                        string Syc = reader["Syc"].ToString();





                                        // ...

                                        // Insert the row into the target database
                                        string insertQuery2 = $"INSERT INTO Visits (Type_of_service,Reason,Diagnosis,TSerProvide,NSerProvide,Medicine,med_allergy,Med_antecedents,TestSCH,ECG,Date,Referral,type_delivery,Delivery_Complic,Num_of_bouys,Gender_of_bouy,Weight_of_bouy,BRM,Death_Mother,Death_Bouy,Referral_From,Referral_To,RH_Service,PatientId,DoctorId,CreatedAt,Syc) VALUES ('{Type_of_service}', '{Reason}', '{Diagnosis}', '{TSerProvide}', '{NSerProvide}', '{Medicine}', '{med_allergy}', '{Med_antecedents}', '{TestSCH}', '{ECG}', '{Date}', '{Referral}', '{type_delivery}', '{Delivery_Complic}', '{Num_of_bouys}', '{Gender_of_bouy}', '{Weight_of_bouy}', '{BRM}', '{Death_Mother}', '{Death_Bouy}', '{Referral_From}', '{Referral_To}', '{RH_Service}', '{PatientId}', '{DoctorId}','{CreatedAt}', '{Syc}')";
                                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery2, targetConnection))
                                        {
                                            insertCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }









                    }
                    bunifuLoader1.Visible = false;
                    bunifuProgressBar2.Value = 100;
                    bunifuCheckBox2.Visible = true;

                    MessageBox.Show("تمت مزامنة البيانات بنجاح");
                    using (MySqlConnection sourceConnection = new MySqlConnection(sourceConnectionString))
                    {
                        sourceConnection.Open();
                        string insertQuery2 = "UPDATE `patients` SET `Syc`= '1'";
                        using (MySqlCommand insertCommand2 = new MySqlCommand(insertQuery2, sourceConnection))
                        {
                            insertCommand2.ExecuteNonQuery();
                        }
                    }
                    using (MySqlConnection sourceConnection = new MySqlConnection(sourceConnectionString))
                    {
                        sourceConnection.Open();
                        string insertQuery2 = "UPDATE `visits` SET `Syc`= '1'";
                        using (MySqlCommand insertCommand2 = new MySqlCommand(insertQuery2, sourceConnection))
                        {
                            insertCommand2.ExecuteNonQuery();
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            this.Close();
        }

        private void Sync_Load(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuProgressBar.ProgressChangedEventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
