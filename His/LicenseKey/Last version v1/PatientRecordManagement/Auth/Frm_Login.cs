using Jenga;
using Kimtoo.ValidationProvider;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientRecordManagement.Auth
{
    [JengaIgnore]
    public partial class Frm_Login : Form
    {
        public string ErrorMessage { get; set; } = "Œÿ√ ›Ì «”„ «·„” Œœ„ «Ê ﬂ·„… «·„—Ê—";

        public Frm_Login()
        {
            InitializeComponent();

            

#if DEBUG
            //for debug purposes
            txtEmail.Text = "admin@email.com";
            txtPassword.Text = "A00000";
#endif
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //add default user
            if (Kt.Db.Count<Models.User>() == 0)
                Kt.Db.Save(new Models.User { 
                   Name = "Default Admin",
                   Email = "admin@email.com",
                   Password = "A00000".ToSHA512Hash()
                });

            //add default clinic
            if (Kt.Db.Count<Models.Clinic>() == 0)
                Kt.Db.Save(new Models.Clinic
                {
                    Name = "ˆÃ«„⁄… Õ·»",
                   
                });

            //validate for errors//«· Õﬁﬁ „‰  —ŒÌ’ «·„ﬂ« »
            if (validationProvider.Validate().Length > 0) return;
            Cursor.Current = Cursors.WaitCursor;
            //check user on database
            var account = Kt.Db.Select<PatientRecordManagement.Models.User>(
                              r => r.Email.ToString().ToLower() == txtEmail.Text.Trim().ToLower()
                                   && r.Password == txtPassword.Text.ToSHA512Hash()
                            ).FirstOrDefault();
            Cursor.Current = Cursors.Default;
           

            if (account == null)  //did  not match any user
            {
                Alert.Show(this, this.ErrorMessage, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            //set identity authentication for easy access
            Authentication.SetIdentity(account);

            //give  feedback close the form
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnSetup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //set up theming 
            Kimtoo.DbManager.Config.Theme = panel1.BackColor;

            Kimtoo.DbManager.Connections.Show();
            
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}