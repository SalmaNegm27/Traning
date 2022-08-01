namespace Traning.UnitOfWorks
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Traning.Models;
    using Traning.Repositories;

    public class StudentUnitOfWork : IStudentUnitOfWork
    {
        private readonly IStudentRepository _studentRepository;
        public StudentUnitOfWork(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<Student>> Read()
        {
            return await _studentRepository.Get();
        }

        public  async Task<Student> Create(Student student)
        {
          return  await _studentRepository.Add(student);

            //using var transaction = await _studentRepository.Database.BeginTransactionAsync();

            //try
            //{
            //    Student studentFromDb = await _studentRepository.Add(student);
            //    await transaction.CommitAsync();
            //    return student;

            //    // Commit transaction if all commands succeed, transaction will auto-rollback
            //    // when disposed if either commands fails

            //}
            //catch (Exception)
            //{
            //   await transaction.RollbackAsync();

            //}
            //return await _studentRepository.Add(student);
        }


        public async Task<Student> Update(Student student)
        {
           return await  _studentRepository.Update(student);
        }
        public  async Task<Student> Delete(int id)
        {
            return await _studentRepository.Remove(id);
        }
    }
}
