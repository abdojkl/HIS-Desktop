using System;
using FoxLearn.License;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientRecordManagement.Register
{
    internal class reg
    {
        


       
            public bool check()
            {
                KeyManager km = new KeyManager(ComputerInfo.GetComputerId());
                LicenseInfo lic1 = new LicenseInfo();
                km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref lic1);
                String productKey = lic1.ProductKey;
                if (km.ValidKey(ref productKey))
                    return (true);
                else
                    return (false);
            }
        }
}
