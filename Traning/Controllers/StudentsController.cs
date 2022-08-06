namespace Traning.Controllers
{
    using Domain.Models;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using I.Repositories;

    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
       private readonly IStudentRepository _studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public async Task<List<Student>> Get()
        {
            return await _studentRepository.GetAll();

        }

        [HttpPost]
        public async Task<Student> Post(Student student)
        {
           await  _studentRepository.Add(student);
            return student;
           
         }
        [HttpPut]
        public async Task<Student> put(Student student)
        {
            
            if(student == null)
                throw new Exception("student doesnot exist");
            await _studentRepository.Edit(student);
            return student;
        }
        //[HttpDelete]
        //public async Task<Student> Delete(int id)
        //{
        //   return await _studentRepository.Delete(id);
        //}
    }
}
