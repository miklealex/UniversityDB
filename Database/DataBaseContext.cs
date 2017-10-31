using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using Database.ClassHierarhy;
using Database.Repository;
namespace Database
{
    public class DataBaseContext : DbContext
    {
        static DataBaseContext()
        {
            System.Data.Entity.Database.SetInitializer<DataBaseContext>(new UContextInitializer());
        }

        public DataBaseContext() : base ("ObjectApproach_1.0")
        {
        }

        public virtual DbSet<DBUniversity> DBUniversitys { get; set; }
        public virtual DbSet<DBPerson> DBPeople { get; set; }
        public virtual DbSet<DBStudent> DBStudents { get; set; }
        public virtual DbSet<DBEntrant> DBEntrants { get; set; }
        public virtual DbSet<DBForeignStudent> DBForeignStudents { get; set; }
        public virtual DbSet<DBWorker> DBWorkers { get; set; }
        public virtual DbSet<DBTeacher> DBTeachers { get; set; }
        public virtual DbSet<DBClass> DBClasses { get; set; }
    }

    public class UContextInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            URepository repo = new URepository();

            repo.CreateClass(typeof(University), null);
            repo.CreateClass(typeof(Person), typeof(University));
            repo.CreateClass(typeof(Student), typeof(Person));
            repo.CreateClass(typeof(ForeignStudent), typeof(Student));
            repo.CreateClass(typeof(Entrant), typeof(Person));
            repo.CreateClass(typeof(Worker), typeof(Person));
            repo.CreateClass(typeof(Teacher), typeof(Worker));
        }
    }
}
