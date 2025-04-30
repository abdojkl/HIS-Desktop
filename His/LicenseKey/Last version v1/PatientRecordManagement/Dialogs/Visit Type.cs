using PatientRecordManagement.Models;
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
    
    public partial class Visit_Type : Form
    {
        int id;
        public Visit_Type(int pationid)
        {
            InitializeComponent();
             id = pationid;
        }
        
        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
           /* this.Hide();
            Women_s frm2 = new Women_s();
            frm2.Show();*/
        }

        private void AppBar_IconClick(object sender, EventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void bunifuFormDock_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void lblBottom_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel9_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel5_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel3_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel2_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void bunifuShadowPanel7_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel8_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton5_Click(object sender, EventArgs e)
        {
           
            var frm = new Clinic.Ambulance.Ambulance(bunifuIconButton1.BackgroundColor, null, false);
             frm.FixedValues.Add("PatientId", this.id);
         
             frm.ShowDialog();
       




        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            
      
            var frm = new Clinic.Dental.Dental(bunifuIconButton1.BackgroundColor, null, false);
            frm.FixedValues.Add("PatientId", this.id);
            frm.ShowDialog();


        }

        private void bunifuIconButton4_Click(object sender, EventArgs e)
        {
            
            var frm = new Clinic.Ear.Ear(bunifuIconButton1.BackgroundColor, null, false);
            frm.FixedValues.Add("PatientId", this.id);
            frm.ShowDialog();


        }

        private void bunifuIconButton8_Click(object sender, EventArgs e)
        {
           

            var frm = new Clinic.Skin.Skin(bunifuIconButton1.BackgroundColor, null, false);
            frm.FixedValues.Add("PatientId", this.id);
            frm.ShowDialog();

        }

        private void bunifuIconButton3_Click(object sender, EventArgs e)
        {
            
            var frm = new Clinic.Child.Child(bunifuIconButton1.BackgroundColor, null, false);
            frm.FixedValues.Add("PatientId", this.id);
            frm.ShowDialog();

        }

        private void bunifuIconButton7_Click(object sender, EventArgs e)
        {
            
            var frm = new Clinic.Referral.Referral(bunifuIconButton1.BackgroundColor, null, false);
            frm.FixedValues.Add("PatientId", this.id);
            frm.ShowDialog();


        }

        private void bunifuIconButton9_Click(object sender, EventArgs e)
        {
           

            var frm = new Clinic.Chronic.Chronic(bunifuIconButton1.BackgroundColor, null, false);
            frm.FixedValues.Add("PatientId", this.id);
            frm.ShowDialog();

        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            

            var frm = new Clinic.Consulting.Consulting(bunifuIconButton1.BackgroundColor, null, false);
            frm.FixedValues.Add("PatientId", this.id);
            frm.ShowDialog();
        }

        private void bunifuIconButton6_Click(object sender, EventArgs e)
        {
            var frm = new Clinic.Delivery.Delivery(bunifuIconButton1.BackgroundColor, null, false);
            frm.FixedValues.Add("PatientId", this.id);
            frm.ShowDialog();

            var frm2 = new Clinic.RH.RH(bunifuIconButton1.BackgroundColor, null, false);
            frm2.FixedValues.Add("PatientId", this.id);
            frm2.ShowDialog();
        }
    }
}
