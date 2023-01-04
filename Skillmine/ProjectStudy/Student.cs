using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.ProjectStudy
{
   public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Marks { get; set; }

    }
    public class StudentClass
    {
        private List<Student> StudentList = null;
        public StudentClass()
        {
            StudentList = new List<Student>();
        }

        public void AddStudent(Student stu)
        {
            StudentList.Add(stu);
        }

        public void UpdateStudent(Student stu)
        {
            foreach (Student item in StudentList)
            {
                if (item.Id == stu.Id)
                {
                    item.Name = stu.Name;
                    item.Marks = stu.Marks;
                    break;
                }
            }
        }

        public void RemoveStudent(int id)
        {
            foreach (Student item in StudentList)
            {
                if(item.Id ==id)
                {
                    StudentList.Remove(item);
                    break;
                }
            }
        }
        public List<Student>List()
        {
            return StudentList;
        }

        public void Filter(Student mark)
        {
            List<Student> studList = null;
            foreach (Student p in studList)
            {
                if (p.Marks > 75)
                {
                    Console.WriteLine($" {p.Id}----{p.Name}-----{p.Marks}");
                }
            }
        }

    }
}

