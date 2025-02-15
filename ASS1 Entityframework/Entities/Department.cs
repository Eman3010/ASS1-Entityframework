using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_Entityframework.Entities
{
    internal class Department
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10)]


        public string Name { get; set; }
        public int Ins_ID { get; set; }
        [Column(TypeName = "date")]
        public string HiringDate { get; set; }
    }
}
