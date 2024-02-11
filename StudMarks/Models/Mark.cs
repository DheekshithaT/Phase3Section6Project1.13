using System;
using System.Collections.Generic;

namespace StudMarks.Models
{
    public partial class Mark
    {
        public int MarksId { get; set; }
        public int? StudentId { get; set; }
        public int? SubjectId { get; set; }
        public double? Marks { get; set; }

        public virtual Student? Student { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
