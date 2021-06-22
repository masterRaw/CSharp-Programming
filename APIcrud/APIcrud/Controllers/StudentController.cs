using APIcrud.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentDataInterface _student;

        public StudentController(IStudentDataInterface studentData)
        {
            _student = studentData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStudents()
        {
            return Ok(_student.GetStudents());
        }

        [HttpGet]
        [Route("api/[controller]/(id)")]
        public IActionResult GetStudent(Guid id)
        {
            return Ok(_student.GetStudent(id));
        }
    }
}
