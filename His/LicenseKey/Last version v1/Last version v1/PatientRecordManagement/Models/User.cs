using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRecordManagement.Models
{
    [AutoGenerateTable(0)]
    [JengaEntity]
    [Alias("Users")]
    public class User : IJengaAuth
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [JengaImage(150, 150)]
      

        [JengaIdentifier]
        public string Name { get; set; }

        [JengaOptions("ذكر,أنثى")]
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [JengaTextArea]
        public string Notes { get; set; }
    
    }
}
