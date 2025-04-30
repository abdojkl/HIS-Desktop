using FoxLearn.License;
using Org.BouncyCastle.Asn1.Cms;
using ServiceStack;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuUserControl.Transitions;

namespace PatientRecordManagement.Pages
{
    public partial class Page_Dashboard : UserControl
    {
        DateTime f_day = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        

        public Page_Dashboard()
        {
            if (IsInDesignMode()) return;
            InitializeComponent();
            dateStartDate_db.Value = f_day;
            
        }
        private static bool IsInDesignMode()
           => (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1);

        public void Page_Dashboard_Load(object sender, EventArgs e)
        {
            LoadWidgets();
            dateEndDate_db.Value = DateTime.Today.AddDays(1);
           
        }

        private void LoadWidgets()
        {
           
            var patients = Kt.Db.Select<Models.Patient>();
            var doctors = Kt.Db.Select<Models.Doctor>();
            var users = Kt.Db.Select<Models.User>();
            var visits = Kt.Db.Select<Models.Visit>();
          

            l11.Text = patients.Where(r =>  r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count().ToString("N0");
            l12.Text = visits.Where(r => r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count().ToString("N0");

            l13.Text = visits.Where(r=>r.Type_of_service == "Referral"&&r.CreatedAt>=dateStartDate_db.Value&&r.CreatedAt<dateEndDate_db.Value).Count().ToString("N0");
            l15.Text = visits.Where(r => r.type_delivery == "طبيعية" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count().ToString("N0");
            l16.Text = patients.Where(r => r.Disability == "نعم" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count().ToString("N0");
            l17.Text = visits.Where(r => r.Type_of_service == "Chronic Clinic" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count().ToString("N0");


            //load charts
           
            String[] month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            
            patient.Data.Clear();
            visits_data.Data.Clear();
            Gender_M.Data.Clear();
            host_idp.Data.Clear();
            disaggregation.Data.Clear();
            typ_visit.Data.Clear();
            M_Status.Data.Clear();
           
          
           for (int j = 1; j <= 12; j++)
            {
               
                patient.Data.Add(patients.Where(r => r.CreatedAt.Year == DateTime.Today.Year && r.CreatedAt.Month == j).Count());
                visits_data.Data.Add(visits.Where(r => r.Date.Year == DateTime.Today.Year && r.Date.Month == j).Count());

            }
            c4.Labels = month;
            Gender_M.Data.Add(patients.Where(r => r.Gender == "ذكر" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            Gender_M.Data.Add(patients.Where(r => r.Gender == "انثى" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            host_idp.Data.Add(patients.Where(r => r.Displacement == "نازح" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt <dateEndDate_db.Value).Count());
            host_idp.Data.Add(patients.Where(r => r.Displacement == "غير نازح" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            disaggregation.Data.Add(patients.Where(r => r.B_G_M_W == "Men" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            disaggregation.Data.Add(patients.Where(r => r.B_G_M_W == "Women" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            disaggregation.Data.Add(patients.Where(r => r.B_G_M_W == "Boys" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            disaggregation.Data.Add(patients.Where(r => r.B_G_M_W == "Girls" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            typ_visit.Data.Add (visits.Where(r => r.Type_of_service == "Ambulance" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            typ_visit.Data.Add ( visits.Where(r => r.Type_of_service == "Child Clinic" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            typ_visit.Data.Add ( visits.Where(r => r.Type_of_service == "Chronic Clinic" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            typ_visit.Data.Add ( visits.Where(r => r.Type_of_service == "Consulting" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            typ_visit.Data.Add ( visits.Where(r => r.Type_of_service == "Delivery" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            typ_visit.Data.Add ( visits.Where(r => r.Type_of_service == "Dental Clinic" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            typ_visit.Data.Add ( visits.Where(r => r.Type_of_service == "Ear Clinic" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            typ_visit.Data.Add ( visits.Where(r => r.Type_of_service == "Referral" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            typ_visit.Data.Add ( visits.Where(r => r.Type_of_service == "RH Clinic" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            typ_visit.Data.Add ( visits.Where(r => r.Type_of_service == "Skin Clinic" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            M_Status.Data.Add(patients.Where(r => r.Status == "متزوج/ة" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            M_Status.Data.Add(patients.Where(r => r.Status == "ارمل/ة" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            M_Status.Data.Add(patients.Where(r => r.Status == "مطلق/ة" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt < dateEndDate_db.Value).Count());
            M_Status.Data.Add(patients.Where(r => r.Status == "اعزب" && r.CreatedAt >= dateStartDate_db.Value && r.CreatedAt <= dateEndDate_db.Value).Count());
            C0.Update();
            c1.Update();
            c2.Update();
            c3.Update();
            c4.Update();
            c5.Update();






        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //refresh widgets every 60 sec
            LoadWidgets();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void l13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void l23_Click(object sender, EventArgs e)
        {

        }

       

        private void l21_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void c1_Load(object sender, EventArgs e)
        {

        }

        private void l11_Click(object sender, EventArgs e)
        {

        }
        private void dateRange_ValueChanged2(object sender, EventArgs e)
            => this.LoadWidgets();

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
