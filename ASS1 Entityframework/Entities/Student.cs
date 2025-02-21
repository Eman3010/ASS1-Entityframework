using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_Entityframework.Entities
{
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public string Address { get; set; }
        public int age { get; set; }

        [ForeignKey("Students")]
        public int? deptID {  get; set; }
        public Ddepartment Ddepartment { get; set; }
       
    }
}
