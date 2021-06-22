using APIcrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIcrud.Data
{
    public interface IStudentDataInterface
    {
        List<Student> GetStudents();

        Student GetStudent(Guid Id);

        Student AddStudent(Student student);

        void deletestudent(Student student);

        Student EditStudent(Student student); 
    }
}
