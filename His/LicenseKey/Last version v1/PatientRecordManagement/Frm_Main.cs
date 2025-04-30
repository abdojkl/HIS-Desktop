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

namespace PatientRecordManagement
{
    public partial class Frm_Main : Form
    {
        private Models.Clinic _clinic;
       

        public Frm_Main()
        {
            
            Register.reg ch = new Register.reg();
            if (!ch.check())
            {
                MessageBox.Show("لم يتم اجراء ترخيص للمنتج الرجاء الأتصال بمسؤول التطبيق للحصول على ترخيص " + "\n\n" + ComputerInfo.GetComputerId(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
            //auth before access main
            if (new Auth.Frm_Login().ShowDialog() != DialogResult.Yes)
                Environment.Exit(0); //kill the app on clossed login
            _clinic = Kt.Db.Single<Models.Clinic>(r => true);



            InitializeComponent();
            

                bunifuAppBar1.Title = _clinic.Name;
            
            //add action buttons
            page_Patient1.ActionButtons.Add("Add Visit", (patient) =>
            {
                var frm = new Dialogs.Visit_Type(patient.Id);
                //frm.FixedValues.Add("PatientId", patient.Id);
                frm.ShowDialog();
                page_Visit1.LoadData();
            });

            page_Patient1.ActionButtons.Add("View Visits", (patient) => new Dialogs.Frm_Patient_Visits(patient).ShowDialog());

            page_User1.ActionButtons.Add("Change Password", (user) => new Auth.Frm_Reset(user).ShowDialog());

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
    }
}
