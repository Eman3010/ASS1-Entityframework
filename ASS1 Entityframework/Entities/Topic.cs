using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_Entityframework.Entities
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
