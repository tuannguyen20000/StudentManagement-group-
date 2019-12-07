using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.StudentManagement
{
    class StudentManagement
    {
        public Student[] GetStudents()
        {
            var db = new StudentEntities();
            return db.Students.ToArray();
        }

        public Student GetStudent(int id)
        {
            var db = new StudentEntities();
            return db.Students.Find(id);
        }

        public void CreateStudent(string code, string name, DateTime birthday, int class_id, string email, string hometown, string subject)
        {
            var student = new Student();
            student.Code = code;
            student.Name = name;
            student.Birthday = birthday;
            student.Class_id = class_id;
            student.Email = email;
            student.Home_Town = hometown;
            student.Subject_ID = subject;

            var db = new StudentEntities();
            db.Students.Add(student);
            db.SaveChanges();
        }

        public void UpdateStudent(int id, string code, string name, DateTime birthday, int class_id, string email, string hometown, string subject)
        {
            var db = new StudentEntities();
            var student = db.Students.Find(id);

            student.Code = code;
            student.Name = name;
            student.Birthday = birthday;
            student.Class_id = class_id;
            student.Email = email;
            student.Home_Town = hometown;
            student.Subject_ID = subject;

            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var db = new StudentEntities();
            var student = db.Students.Find(id);

            db.Students.Remove(student);
            db.SaveChanges();
        }
        public Class[] GetClasses()
        {
            var db = new StudentEntities();
            return db.Classes.ToArray();
        }
        public Subject[] getSubjects()
        {
            var db = new StudentEntities();
            return db.Subjects.ToArray();
        }
    }
}
