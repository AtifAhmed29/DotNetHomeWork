//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task02.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseStudent
    {
        public int id { get; set; }
        public int studentId { get; set; }
        public int courseId { get; set; }
        public string status { get; set; }
        public string grade { get; set; }
        public Nullable<int> marks { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Student Student { get; set; }
    }
}
