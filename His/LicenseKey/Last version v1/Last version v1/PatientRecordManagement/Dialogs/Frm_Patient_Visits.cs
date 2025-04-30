using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientRecordManagement.Dialogs
{
    public partial class Frm_Patient_Visits : Form
    {
        public Frm_Patient_Visits(Models.Patient patient)
        {
            InitializeComponent();

            page_Visit1.FixedValues.Add("PatientId", patient.Id);

            page_Visit1.SetDataFilter(r => r.Where(rr => rr.PatientId == patient.Id));
            page_Visit1.column_Date.DefaultCellStyle.Format = "d";
            AppBar.Title = $"Patient Visits - {patient.Name}";

            page_Visit1.grid.CellClick += (s, e) =>
              {
                  //refresh charts here
                  if (page_Visit1.GetCurrentRecords() == null) return;
                  var data = page_Visit1.GetCurrentRecords().OrderBy(r=>r.Date).GroupBy(r => r?.Date.Date);
                  var labels = data.Select(r => r.Key?.ToShortDateString()).ToArray();
                  if ( string.Join("", chartBlood.Labels??new List<string>().ToArray()) == string.Join("", labels)) return;
                  chartBlood.Labels = labels;
                  chartWT.Labels = labels;
                  diastolic.Data.Clear();
                  systolic.Data.Clear();
                  temp.Data.Clear();
                  weight.Data.Clear();

                  foreach (var visits in data)
                  {
                      diastolic.Data.Add(visits.Sum(r => r == null ? 0 : r.Diastolic));
                      systolic.Data.Add(visits.Sum(r => r == null ? 0 : r.Systolic));
                      temp.Data.Add(visits.Sum(r => r == null ? 0 : r.Temperature));
                      weight.Data.Add(visits.Sum(r => r == null ? 0 : r.Weight));
                  }
                  chartBlood.Update(true);
                  chartWT.Update(true);

              };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            bunifuFormDock.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
        }

        private void page_Visit1_SelectionChanged(Models.Visit e)
        {

        }

        private void page_Visit1_Load(object sender, EventArgs e)
        {

        }
    }
}
