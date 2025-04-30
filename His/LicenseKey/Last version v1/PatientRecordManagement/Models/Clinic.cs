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
    public class Clinic
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [JengaIdentifier]
        public string Name { get; set; }

        public string Project_number { get; set; }

        public string Governorate { get; set; }
        public string Address { get; set; }
        

        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
