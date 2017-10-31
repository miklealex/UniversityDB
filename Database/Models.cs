using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database
{
    public class DBClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("Parent")]
        public int? ParentId { get; set; }
        public virtual DBClass Parent { get; set; }
    }

    public class DBUObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Major")]
        public int? MajorId { get; set; }
        public virtual DBUObject Major { get; set; }

        public string Title { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastWriteTime { get; set; }

        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public virtual DBClass Class { get; set; }
    }

    public class DBPerson
    {
        [Key, ForeignKey("DBUObject")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUObject DBUObject { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
    }

    public class DBStudent
    {
        [Key, ForeignKey("DBUObject")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUObject DBUObject { get; set; }

        public int Course { get; set; }
        public DateTime EntryDate { get; set; }
    }

    public class DBEntrant
    {
        [Key, ForeignKey("DBUObject")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUObject DBUObject { get; set; }

        public int IEE { get; set; }
        public double GPA { get; set; }
    }

    public class DBForeignStudent
    {
        [Key, ForeignKey("DBUObject")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUObject DBUObject { get; set; }

        public string Nationality { get; set; }
        public string University { get; set; }
    }

    public class DBWorker
    {
        [Key, ForeignKey("DBUObject")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUObject DBUObject { get; set; }

        public double Salary { get; set; }
        public DateTime EmploymentDate { get; set; }
    }

    public class DBTeacher
    {
        [Key, ForeignKey("DBUObject")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUObject DBUObject { get; set; }

        public string Position { get; set; }
    }
}
