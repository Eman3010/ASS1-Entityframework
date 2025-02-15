using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_Entityframework.Entities
{
    internal class Stud_Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Stud_ID { get; set; }

        [Required]
        public int Course_ID { get; set;}

        [Required]
        [Column(TypeName ="varchar")]

        public string grade {  get; set; }
    }
}
