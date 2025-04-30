using FoxLearn.License;
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

        private void Page_Dashboard_Load(object sender, EventArgs e)
        {
            LoadWidgets();
        }

        private void LoadWidgets()
        {
           
            var patients = Kt.Db.Select<Models.Patient>();
            var doctors = Kt.Db.Select<Models.Doctor>();
            var users = Kt.Db.Select<Models.User>();
            var visits = Kt.Db.Select<Models.Visit>();
          

            l11.Text = patients.Count().ToString("N0");
            l12.Text = visits.Count().ToString("N0");

            l13.Text = patients.Where(r=>r.CreatedAt.Date >= dateStartDate_db.Value.Date && r.CreatedAt.Date <= dateEndDate_db.Value.Date).Count().ToString("N0");
            l14.Text = visits.Where(r => r.Date.Date >= dateStartDate_db.Value.Date && r.Date.Date <= dateEndDate_db.Value.Date).Count().ToString("N0");


            

            //load charts
            List<string> str = new List<string>();
            String[] month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            dp.Data.Clear();
            dv.Data.Clear();
            patient.Data.Clear();
            visits_data.Data.Clear();
            for (int i = 1; i <= 31; i++)
            {
                str.Add(i.ToString());
                dp.Data.Add(patients.Where(r => r.CreatedAt.Year == DateTime.Today.Year && r.CreatedAt.Month == DateTime.Today.Month && r.CreatedAt.Day==i).Count());
                dv.Data.Add(visits.Where(r => r.Date.Year == DateTime.Today.Year && r.Date.Month == DateTime.Today.Month && r.CreatedAt.Day == i).Count());

            }
          
           for (int j = 1; j <= 12; j++)
            {
               
                patient.Data.Add(patients.Where(r => r.CreatedAt.Year == DateTime.Today.Year && r.CreatedAt.Month == j).Count());
                visits_data.Data.Add(visits.Where(r => r.Date.Year == DateTime.Today.Year && r.Date.Month == j).Count());

            }
            c4.Labels = month;

          /*  str.Clear();
            mv.Data.Clear();
            for (int i = 1; i <= 12; i++)
            {
                str.Add(i.ToString());
                mp.Data.Add(patients.Where(r => r.CreatedAt.Year == DateTime.Today.Year && r.CreatedAt.Month == i).Count());
                mv.Data.Add(visits.Where(r => r.Date.Year == DateTime.Today.Year && r.Date.Month == i).Count());
            }
            c4.Labels = str.ToArray();*/

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

        private void c3_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void c4_Load(object sender, EventArgs e)
        {

        }

        private void c6_Load(object sender, EventArgs e)
        {

        }

        private void c5_Load(object sender, EventArgs e)
        {

        }

        private void c2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel4_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
