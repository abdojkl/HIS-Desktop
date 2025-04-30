using FoxLearn.License;
using PatientRecordManagement.Pages;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

using MySql.Data.MySqlClient;
using ServiceStack.OrmLite.Dapper;
using System.Security.Cryptography;
using System.Windows.Forms.DataVisualization.Charting;
using Org.BouncyCastle.Utilities.Collections;
using PatientRecordManagement.Models;
using ServiceStack.Script;
using Jenga;
using System.Security.Principal;

namespace PatientRecordManagement
{
    public partial class Frm_Main : Form
    {
        private Models.Clinic _clinic;
        private Models.User _roll;

        public Frm_Main()
        {
            
            Register.reg ch = new Register.reg();
            if (!ch.check())
            {
                MessageBox.Show("لم يتم اجراء ترخيص للمنتج الرجاء نسخ معرف الجهاز و الأتصال بمسؤول التطبيق للحصول على ترخيص " + "\n\n (Ctrl+C) To Copy :\n\n ID : " + ComputerInfo.GetComputerId() + "\n\n Email : abdojkl876@gmail.com \n Phone : 00963947948533", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
            //auth before access main
            if (new Auth.Frm_Login().ShowDialog() != DialogResult.Yes)
                Environment.Exit(0); //kill the app on clossed login
            _clinic = Kt.Db.Single<Models.Clinic>(r => true);



            InitializeComponent();
           
           
            bunifuAppBar1.Title = _clinic.Name;

            _roll = Kt.Db.Single<Models.User>(r => true);


            //add action buttons                      
            Pages.Page_Patient page = new Pages.Page_Patient();

            if (_roll.roll.ToString() == "admin")
            {
               
               
                page_Patient1.ActionButtons.Add("Add Visit", (patient) =>
                {
                    var frm = new Dialogs.Visit_Type(patient.Id);
                    //frm.FixedValues.Add("PatientId", patient.Id);
                    frm.ShowDialog();
                    page_Visit1.LoadData();
                });


                page_Patient1.ActionButtons.Add("View Visits", (patient) => new Dialogs.Frm_Patient_Visits(patient).ShowDialog());

                page_User1.ActionButtons.Add("Change Password", (user) => new Auth.Frm_Reset(user).ShowDialog());
                bunifuButton3.Visible = true;
            }


            else if (_roll.roll.ToString() == "read_only")
            {
                bunifuButton3.Visible = false;
                page_Patient1.btnAdd.Enabled = false;
                page_Patient1.btnDelete.Enabled = false;
                page_Visit1.btnDelete.Enabled = false;
                page_Doctor1.btnDelete.Enabled = false;
                page_Doctor1.btnAdd.Enabled = false;
                page_Patient1.grid.Columns.Remove("ColEdit");
                page_Patient1.grid.Columns.Remove("colDel");
                page_Visit1.grid.Columns.Remove("ColEdit");
                page_Visit1.grid.Columns.Remove("colDel");
                page_Doctor1.grid.Columns.Remove("ColEdit");
                page_Doctor1.grid.Columns.Remove("colDel");

            }
            else if (_roll.roll.ToString() == "user")
            {
              
                page_Patient1.ActionButtons.Add("Add Visit", (patient) =>
                {
                    var frm = new Dialogs.Visit_Type(patient.Id);
                    //frm.FixedValues.Add("PatientId", patient.Id);
                    frm.ShowDialog();
                    page_Visit1.LoadData();
                });


                page_Patient1.ActionButtons.Add("View Visits", (patient) => new Dialogs.Frm_Patient_Visits(patient).ShowDialog());

                page_User1.ActionButtons.Add("Change Password", (user) => new Auth.Frm_Reset(user).ShowDialog());
                bunifuButton3.Visible = false;


            }               

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            bunifuFormDock1.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;

        }

        private void btnNav_Click(object sender, EventArgs e)
        {

            pages.SetPage(((Control)sender).Text.Trim());
            indicator.Width = ((Control)sender).Width;
            indicator.Left = ((Control)sender).Left;


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnCLinic_Click(object sender, EventArgs e)
        {
            new Dialogs.Frm_Clinic(bunifuAppBar1.BackColor, _clinic).ShowDialog();
            bunifuAppBar1.Title = _clinic.Name;

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new Dialogs.Frm_User(bunifuAppBar1.BackColor, Jenga.Authentication.GetIdentity<Models.User>()).ShowDialog();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            new Syc.Sync().ShowDialog();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var visits = Kt.Db.Select<Models.Visit>();
            var patients = Kt.Db.Select<Models.Patient>();
            
            if ((patients.Where(r => r.Syc == false).Count() )> 0)
                   pat_syc_icon.Visible = true;
            else
                pat_syc_icon.Visible = false;


            if ((visits.Where(r => r.Syc ==false).Count()) > 0)
            
                vis_syc_icon.Visible = true;
            else
                vis_syc_icon.Visible = false;



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void page_Doctor1_Load(object sender, EventArgs e)
        {

        }

        private void page_User1_Load(object sender, EventArgs e)
        {

        }
    }
}
