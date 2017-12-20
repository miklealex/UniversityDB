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

    public class DBUniversity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Major")]
        public int? ParentId { get; set; }
        public virtual DBUniversity Major { get; set; }

        public string Title { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastWriteTime { get; set; }

        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public virtual DBClass Class { get; set; }
    }

    public class DBPerson
    {
        [Key, ForeignKey("DBUniversity")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUniversity DBUniversity { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
    }

    public class DBFaculty
    {
        [Key, ForeignKey("DBUniversity")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUniversity DBUniversity { get; set; }

        public string FacultyName { get; set; }

        [ForeignKey("Den")]
        public int TeacherId { get; set; }
        public DBTeacher Den { get; set; }
    }

    public class DBInstitute
    {
        [Key, ForeignKey("DBUniversity")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUniversity DBUniversity { get; set; }

        public string InstituteName { get; set; }
        public int facultyId { get; set; }
        [ForeignKey("Head")]
        public int HeadId { get; set; }
        public DBTeacher Head { get; set; }
    }

    public class DBStudent
    {
        [Key, ForeignKey("DBUniversity")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUniversity DBUniversity { get; set; }

        public int Course { get; set; }
        public DateTime EntryDate { get; set; }
    }

    public class DBEntrant
    {
        [Key, ForeignKey("DBUniversity")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUniversity DBUniversity { get; set; }

        public int IEE { get; set; }
        public double GPA { get; set; }
    }

    public class DBForeignStudent
    {
        [Key, ForeignKey("DBUniversity")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUniversity DBUniversity { get; set; }

        public string Nationality { get; set; }
        public string University { get; set; }
    }

    public class DBWorker
    {
        [Key, ForeignKey("DBUniversity")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUniversity DBUniversity { get; set; }

        public double Salary { get; set; }
        public DateTime EmploymentDate { get; set; }
    }

    public class DBTeacher
    {
        [Key, ForeignKey("DBUniversity")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual DBUniversity DBUniversity { get; set; }

        public string Position { get; set; }

        public int InstituteId { get; set; }
    }
}
