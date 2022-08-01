namespace Traning.UnitOfWorks
{
    using Traning.Models;

    public interface IStudentUnitOfWork
    {
        
        Task<List<Student>> Read();
        Task<Student> Create(Student student);
        Task<Student> Update(Student student);
        Task<Student> Delete(int id);

    }
}
