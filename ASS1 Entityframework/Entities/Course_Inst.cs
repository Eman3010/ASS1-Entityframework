using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_Entityframework.Entities
{
    internal class Course_Inst
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int inst_ID { get; set; }

        [Required]
        public int Course_ID { get; set;}

        [Column(TypeName="varchar")]
        public string evaluate { get;}
    }
}
