﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class UObject
    {
        public int Id { get; set; }
        public int? MajorId { get; set; }
        public string Title { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastWriteTime { get; set; }
        public string ClassName { get; set; }
        public string MajorTitle { get; set; }

        public UObject() { }

        public UObject(DBUObject dbUObj)
        {
            Id = dbUObj.Id;
            MajorId = dbUObj.MajorId;
            Title = dbUObj.Title;
            CreationTime = dbUObj.CreationTime;
            LastWriteTime = dbUObj.LastWriteTime;
            ClassName = dbUObj.Class.Name;
            MajorTitle = dbUObj.Major == null ? "" : dbUObj.Major.Title;
        }
    }

    public class Person : UObject
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }

        public Person() { }

        public Person(DBPerson dbPerson) 
            : base(dbPerson.DBUObject)
        {
            Name = dbPerson.Name;
            Surname = dbPerson.Surname;
            Birthday = dbPerson.Birthday;
            Gender = dbPerson.Gender;
        }
    }

    public class Student : Person
    {
        public int Course { get; set; }
        public DateTime EntryDate { get; set; }

        public Student() { }

        public Student(DBStudent dbStudent, UContext context) 
            : base(context.DBPeople.First(p => p.Id == dbStudent.Id))
        {
            Course = dbStudent.Course;
            EntryDate = dbStudent.EntryDate;
        }
    }

    public class Entrant : Person
    {
        public int IEE { get; set; }
        public double GPA { get; set; }

        public Entrant() { }

        public Entrant(DBEntrant dbEntrant, UContext context)
            : base(context.DBPeople.First(p => p.Id == dbEntrant.Id))
        {
            IEE = dbEntrant.IEE;
            GPA = dbEntrant.GPA;
        }
    }

    public class ForeignStudent : Student
    {
        public string Nationality { get; set; }
        public string University { get; set; }

        public ForeignStudent() { }

        public ForeignStudent(DBForeignStudent dbForeignStudent, UContext context)
            : base(context.DBStudents.First(s => s.Id == dbForeignStudent.Id), context)
        {
            Nationality = dbForeignStudent.Nationality;
            University = dbForeignStudent.University;
        }
    }

    public class Worker : Person
    {
        public double Salary { get; set; }
        public DateTime EmploymentDate { get; set; }

        public Worker() { }

        public Worker(DBWorker dbWorker, UContext context)
            : base(context.DBPeople.First(p => p.Id == dbWorker.Id))
        {
            Salary = dbWorker.Salary;
            EmploymentDate = dbWorker.EmploymentDate;
        }
    }

    public class Teacher : Worker
    {
        public string Position { get; set; }

        public Teacher() { }

        public Teacher(DBTeacher dbTeacher, UContext context)
            : base(context.DBWorkers.First(w => w.Id == dbTeacher.Id), context)
        {
            Position = dbTeacher.Position;
        }
    }
}
