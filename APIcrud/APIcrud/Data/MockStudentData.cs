using APIcrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIcrud.Data
{
    public class MockStudentData : IStudentDataInterface
    {
        private List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Student 1"
            },
            new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Student 2"
            }
        };

        public Student AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void deletestudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Student EditStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public Student GetStudent(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
