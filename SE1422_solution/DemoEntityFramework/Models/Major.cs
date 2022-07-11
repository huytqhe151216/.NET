using System;
using System.Collections.Generic;

#nullable disable

namespace DemoEntityFramework.Models
{
    public partial class Major
    {
        public Major()
        {
            Students = new HashSet<Student>();
        }

        public string Code { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }

        public virtual ICollection<Student> Students { get; set; }
    }
}
