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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Bishop_Entities : DbContext
    {
        public Bishop_Entities()
            : base("name=Bishop_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<CourseStudent> CourseStudents { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}
