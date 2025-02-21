using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_Entityframework.Entities
{
    internal class Ddepartment
    {
        public int ID { get; set; }
        public string Name { get; set; }
       
        public  DateTime HiringDate { get; set; }

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
      
        [ForeignKey("Departments")]
        public int? InsID { get; set; }
        [InverseProperty("Departments")]
        public Instructor Instructor { get; set; }

        public ICollection<Instructor> inst {  get; set; }
    }
}
