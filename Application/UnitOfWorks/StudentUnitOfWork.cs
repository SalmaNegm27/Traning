//namespace Application.UnitOfWorks
//{
//    using Application.Repositories;
//    using Domain.Models;
 
//    using System.Collections.Generic;
//    using System.Threading.Tasks;
    
//    public class StudentUnitOfWork : IStudentUnitOfWork
//    {
//        private readonly IStudentRepository _studentRepository;
//        public StudentUnitOfWork(IStudentRepository studentRepository)
//        {
//            _studentRepository = studentRepository;
//        }

//        public async Task<List<Student>> Read()
//        {
//            return await _studentRepository.Get();
//        }

//        public  async Task<Student> Create(Student student)
//        {
//          return  await _studentRepository.Add(student);
//        }


//        public async Task<Student> Update(Student student)
//        {
//           return await  _studentRepository.Update(student);
//        }
//        public  async Task<Student> Delete(int id)
//        {
//            return await _studentRepository.Remove(id);
//        }

//    }
//}
