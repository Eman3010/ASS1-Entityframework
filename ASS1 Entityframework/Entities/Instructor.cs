using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_Entityframework.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Bouns { get; set; }
        public decimal salary { get; set;}
        public string Address { get; set; }
        public double HourRate { get; set; }
        [InverseProperty("Instructor")]
        public ICollection<Ddepartment> Departments { get; set; } = new HashSet<Ddepartment>();
        //[ForeignKey("inst")]
        public int? deptId { get; set; }
        public Ddepartment ddepartment { get; set; }
    }
}
