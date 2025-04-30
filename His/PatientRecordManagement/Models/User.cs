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
        
       

        [JengaIdentifier]
        public string roll { get; set; }

        [JengaOptions("Male,Female,Non-Binary")]
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [JengaTextArea]
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
