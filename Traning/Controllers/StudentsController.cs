namespace Traning.Controllers
{
    using Domain.Models;
    using Application.UnitOfWorks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

  

    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
       private readonly IStudentUnitOfWork _studentUnitOfWork;
        public StudentsController(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork; 
        }

        [HttpGet]
        public async Task<List<Student>> Get()
        {
            return await _studentUnitOfWork.Read();

        }

        [HttpPost]
        public async Task<Student> Post(Student student)
        {
           return await _studentUnitOfWork.Create(student);
        }
        [HttpPut]
        public async Task<Student> put(Student student)
        {
            return await _studentUnitOfWork.Update(student);
        }
        [HttpDelete]
        public async Task<Student> Delete(int id)
        {
           return await _studentUnitOfWork.Delete(id);
        }
    }
}
