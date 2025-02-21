using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_Entityframework.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       public string Duration{ get; set; }
        [ForeignKey("Courses")]
        public int? topId { get; set; }
        public  Topic topic { get; set; }

        
    }
}
