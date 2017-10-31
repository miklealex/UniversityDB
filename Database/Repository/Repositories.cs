using System;
using System.Collections.Generic;
using System.Linq;
using Database.ClassHierarhy;
using System.Data;

namespace Database.Repository
{
    public class URepository
    {
        private UContext context;

        public URepository()
        {
            context = new UContext();
        }

        #region Universitys => context.DBUniversitys.Where(o => o.Sealed).ToList().Select(uobj => new University(uobj));

        private IEnumerable<University> Universitys => context.DBUniversitys
            .Where(o => o.Class.Name == typeof(University).Name).ToList()
            .Select(uobj => new University(uobj));

        private IEnumerable<Person> People => context.DBPeople
            .Where(o => o.DBUniversity.Class.Name == typeof(Person).Name).ToList()
            .Select(person => new Person(person));

        private IEnumerable<Student> Students => context.DBStudents
            .Where(o => o.DBUniversity.Class.Name == typeof(Student).Name).ToList()
            .Select(student => new Student(student, context));

        private IEnumerable<Entrant> Entrants => context.DBEntrants
            .Where(o => o.DBUniversity.Class.Name == typeof(Entrant).Name).ToList()
            .Select(entrant => new Entrant(entrant, context));

        private IEnumerable<ForeignStudent> ForeignStudents => context.DBForeignStudents
            .Where(o => o.DBUniversity.Class.Name == typeof(ForeignStudent).Name).ToList()
            .Select(student => new ForeignStudent(student, context));

        private IEnumerable<Worker> Workers => context.DBWorkers
            .Where(o => o.DBUniversity.Class.Name == typeof(Worker).Name).ToList()
            .Select(worker => new Worker(worker, context));

        private IEnumerable<Teacher> Teachers => context.DBTeachers
            .Where(o => o.DBUniversity.Class.Name == typeof(Teacher).Name).ToList()
            .Select(teacher => new Teacher(teacher, context));

        #endregion

        #region Create. private methods

        private int CreateUniversity(University uobj, DBClass dbclass)
        {
            uobj.CreationTime = DateTime.Now;
            uobj.LastWriteTime = DateTime.Now;

            DBUniversity dbUObj = new DBUniversity
            {
                CreationTime = uobj.CreationTime,
                LastWriteTime = uobj.LastWriteTime,
                ParentId = uobj.ParentId,
                Title = uobj.Title,
                ClassId = dbclass.Id
            };

            context.DBUniversitys.Add(dbUObj);
            context.SaveChanges();

            uobj.Id = dbUObj.Id;
            return dbUObj.Id;
        }

        private int CreatePerson(Person person, DBClass dbclass)
        {
            int id = CreateUniversity(person, dbclass);

            DBPerson dbPerson = new DBPerson
            {
                Birthday = person.Birthday,
                Gender = person.Gender,
                Name = person.Name,
                Surname = person.Surname,
                Id = id,
            };

            context.DBPeople.Add(dbPerson);
            context.SaveChanges();

            person.Id = id;
            return id;
        }

        private int CreateStudent(Student student, DBClass dbclass)
        {
            int id = CreatePerson(student, dbclass);

            DBStudent dbStudent = new DBStudent
            {
                Course = student.Course,
                EntryDate = student.EntryDate,
                Id = id
            };

            context.DBStudents.Add(dbStudent);
            context.SaveChanges();

            student.Id = id;
            return id;
        }

        private int CreateEntrant(Entrant entrant, DBClass dbclass)
        {
            int id = CreatePerson(entrant, dbclass);

            DBEntrant dbEntrant = new DBEntrant
            {
                GPA = entrant.GPA,
                IEE = entrant.IEE,
                Id = id
            };

            context.DBEntrants.Add(dbEntrant);
            context.SaveChanges();

            entrant.Id = id;
            return id;
        }

        private int CreateForeignStudent(ForeignStudent foreignStudent, DBClass dbclass)
        {
            int id = CreateStudent(foreignStudent, dbclass);

            DBForeignStudent dbForeignStudent = new DBForeignStudent
            {
                Nationality = foreignStudent.Nationality,
                University = foreignStudent.University,
                Id = id
            };

            context.DBForeignStudents.Add(dbForeignStudent);
            context.SaveChanges();

            foreignStudent.Id = id;
            return id;
        }

        private int CreateWorker(Worker worker, DBClass dbclass)
        {
            int id = CreatePerson(worker, dbclass);

            DBWorker dbWorker = new DBWorker
            {
                EmploymentDate = worker.EmploymentDate,
                Salary = worker.Salary,
                Id = id
            };

            context.DBWorkers.Add(dbWorker);
            context.SaveChanges();

            worker.Id = id;
            return id;
        }

        private int CreateTeacher(Teacher teacher, DBClass dbclass)
        {
            int id = CreateWorker(teacher, dbclass);

            DBTeacher dbTeacher = new DBTeacher
            {
                Position = teacher.Position,
                Id = id
            };

            context.DBTeachers.Add(dbTeacher);
            context.SaveChanges();

            teacher.Id = id;
            return id;
        }

        #endregion


        #region Create

        public int CreateUniversity(University uobj)
        {
            string className = uobj.GetType().Name;
            return CreateUniversity(uobj, context.DBClasses
                .First(c => c.Name == className));
        }

        public int CreatePerson(Person person)
        {
            string className = person.GetType().Name;
            return CreatePerson(person, context.DBClasses
                .First(c => c.Name == className));
        }

        public int CreateStudent(Student student)
        {
            string className = student.GetType().Name;
            return CreateStudent(student, context.DBClasses
                .First(c => c.Name == className));
        }

        public int CreateEntrant(Entrant entrant)
        {
            string className = entrant.GetType().Name;
            return CreateEntrant(entrant, context.DBClasses
                .First(c => c.Name == className));
        }

        public int CreateForeignStudent(ForeignStudent foreignStudent)
        {
            string className = foreignStudent.GetType().Name;
            return CreateForeignStudent(foreignStudent, context.DBClasses
                .First(c => c.Name == className));
        }

        public int CreateWorker(Worker worker)
        {
            string className = worker.GetType().Name;
            return CreateWorker(worker, context.DBClasses
                .First(c => c.Name == className));
        }

        public int CreateTeacher(Teacher teacher)
        {
            string className = teacher.GetType().Name;
            return CreateTeacher(teacher, context.DBClasses
                .First(c => c.Name == className));
        }

        #endregion

        #region Read

        public University GetUniversityById(int id)
        {
            DBUniversity dbUObj = context.DBUniversitys.First(o => o.Id == id);
            return new University(dbUObj);
        }

        public Person GetPersonById(int id)
        {
            DBPerson dbPerson = context.DBPeople.First(p => p.Id == id);
            return new Person(dbPerson);
        }

        public Student GetStudentById(int id)
        {
            DBStudent dbStudent = context.DBStudents.First(s => s.Id == id);
            return new Student(dbStudent, context);
        }

        public Entrant GetEntrantById(int id)
        {
            DBEntrant dbEntrant = context.DBEntrants.First(e => e.Id == id);
            return new Entrant(dbEntrant, context);
        }

        public ForeignStudent GetForeignStudentById(int id)
        {
            DBForeignStudent dbForeignStudent = context.DBForeignStudents.First(fs => fs.Id == id);
            return new ForeignStudent(dbForeignStudent, context);
        }

        public Worker GetWorkerById(int id)
        {
            DBWorker dbWorker = context.DBWorkers.First(w => w.Id == id);
            return new Worker(dbWorker, context);
        }

        public Teacher GetTeacherById(int id)
        {
            DBTeacher dbTeacher = context.DBTeachers.First(t => t.Id == id);
            return new Teacher(dbTeacher, context);
        }

        #endregion

        #region Update

        public void UpdateUniversity(University uObj)
        {
            DBUniversity dbUObj = context.DBUniversitys.First(o => o.Id == uObj.Id);
            dbUObj.Title = uObj.Title;
            dbUObj.LastWriteTime = DateTime.Now;
            context.SaveChanges();
        }

        public void UpdatePerson(Person person)
        {
            DBPerson dbPerson = context.DBPeople.First(p => p.Id == person.Id);

            dbPerson.Name = person.Name;
            dbPerson.Surname = person.Surname;
            dbPerson.Birthday = person.Birthday;
            dbPerson.Gender = person.Gender;

            UpdateUniversity(person);
        }

        public void UpdateStudent(Student student)
        {
            DBStudent dbStudent = context.DBStudents.First(s => s.Id == student.Id);

            dbStudent.EntryDate = student.EntryDate;
            dbStudent.Course = student.Course;

            UpdatePerson(student);
        }

        public void UpdateEntrant(Entrant entrant)
        {
            DBEntrant dbEntrant = context.DBEntrants.First(e => e.Id == entrant.Id);

            dbEntrant.GPA = entrant.GPA;
            dbEntrant.IEE = entrant.IEE;

            UpdatePerson(entrant);
        }

        public void UpdateForeignStudent(ForeignStudent foreignStudent)
        {
            DBForeignStudent dbForeignStudent = context.DBForeignStudents.First(fs => fs.Id == foreignStudent.Id);

            dbForeignStudent.Nationality = foreignStudent.Nationality;
            dbForeignStudent.University = foreignStudent.University;

            UpdateStudent(foreignStudent);
        }

        public void UpdateWorker(Worker worker)
        {
            DBWorker dbWorker = context.DBWorkers.First(w => w.Id == worker.Id);

            dbWorker.EmploymentDate = worker.EmploymentDate;
            dbWorker.Salary = worker.Salary;

            UpdatePerson(worker);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            DBTeacher dbTeacher = context.DBTeachers.First(t => t.Id == teacher.Id);

            dbTeacher.Position = teacher.Position;

            UpdateWorker(teacher);
        }

        #endregion

        #region Delete

        public void DeleteUniversity(int id)
        {
            DBUniversity forRemove = context.DBUniversitys.First(o => o.Id == id);

            context.DBUniversitys.Remove(forRemove);

            context.SaveChanges();
        }

        public void DeletePerson(int id)
        {
            DBPerson forRemove = context.DBPeople.First(p => p.Id == id);

            context.DBPeople.Remove(forRemove);

            DeleteUniversity(id);
        }

        public void DeleteStudent(int id)
        {
            DBStudent forRemove = context.DBStudents.First(s => s.Id == id);

            context.DBStudents.Remove(forRemove);

            DeletePerson(id);
        }

        public void DeleteEntrant(int id)
        {
            DBEntrant forRemove = context.DBEntrants.First(e => e.Id == id);

            context.DBEntrants.Remove(forRemove);

            DeletePerson(id);
        }

        public void DeleteForeignStudent(int id)
        {
            DBForeignStudent forRemove = context.DBForeignStudents.First(fs => fs.Id == id);

            context.DBForeignStudents.Remove(forRemove);

            DeleteStudent(id);
        }

        public void DeleteWorker(int id)
        {
            DBWorker forRemove = context.DBWorkers.First(w => w.Id == id);

            context.DBWorkers.Remove(forRemove);

            DeletePerson(id);
        }

        public void DeleteTeacher(int id)
        {
            DBTeacher forRemove = context.DBTeachers.First(t => t.Id == id);

            context.DBTeachers.Remove(forRemove);

            DeleteWorker(id);
        }

        #endregion

        #region GetUniversitysByMajor(int? major)

        public IEnumerable<University> GetUniversitysByMajor(int? major)
        {
            return Universitys.Where(o => o.ParentId == major);
        }

        public IEnumerable<Person> GetPeopleByMajor(int? major)
        {
            return People.Where(p => p.ParentId == major);
        }

        public IEnumerable<Student> GetStudentsByMajor(int? major)
        {
            return Students.Where(s => s.ParentId == major);
        }

        public IEnumerable<Entrant> GetEntrantsByMajor(int? major)
        {
            return Entrants.Where(e => e.ParentId == major);
        }

        public IEnumerable<ForeignStudent> GetForeignStudentsByMajor(int? major)
        {
            return ForeignStudents.Where(fs => fs.ParentId == major);
        }

        public IEnumerable<Worker> GetWorkersByMajor(int? major)
        {
            return Workers.Where(w => w.ParentId == major);
        }

        public IEnumerable<Teacher> GetTeachersByMajor(int? major)
        {
            return Teachers.Where(t => t.ParentId == major);
        }

        public IEnumerable<University> GetAllObjectsByMajor(int? major)
        {
            return context.DBUniversitys.Where(o => o.ParentId == major).ToList().Select(o => new University(o));
        }

        //public Dictionary<string, IEnumerable<University>> GetAllObjectsByMajor(int? major)
        //{
        //    Dictionary<string, IEnumerable<University>> dictionary = new Dictionary<string, IEnumerable<University>>();
        //    dictionary.Add("University Object", GetUniversitysByMajor(major));
        //    dictionary.Add("Person", GetPeopleByMajor(major));
        //    dictionary.Add("Student", GetStudentsByMajor(major));
        //    dictionary.Add("Entrant", GetEntrantsByMajor(major));
        //    dictionary.Add("Foreign Student", GetForeignStudentsByMajor(major));
        //    dictionary.Add("Worker", GetWorkersByMajor(major));
        //    dictionary.Add("Teacher", GetTeachersByMajor(major));

        //    return dictionary;
        //}

        //public IEnumerable<University> GetAllObjectsByMajor(int? major)
        //{
        //    return GetUniversitysByMajor(major)
        //        .Concat(GetPeopleByMajor(major))
        //        .Concat(GetStudentsByMajor(major))
        //        .Concat(GetEntrantsByMajor(major))
        //        .Concat(GetForeignStudentsByMajor(major))
        //        .Concat(GetWorkersByMajor(major))
        //        .Concat(GetTeachersByMajor(major));
        //}

        #endregion

        public void CreateClass(Type type, Type parent)
        {
            DBClass dbclass = new DBClass
            {
                Name = type.Name, 
                ParentId = null
            };

            if (parent != null)
            {
                dbclass.ParentId = context.DBClasses.First(c => c.Name == parent.Name).Id;
            }

            context.DBClasses.Add(dbclass);
            context.SaveChanges();
        }

        public List<string> GetClassesNames()
        {
            return context.DBClasses.Select(dbclass => dbclass.Name).ToList();
        }
    }
}
