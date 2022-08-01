namespace Traning.Repositories
{
    using Traning.Models;

    public interface IStudentRepository
    {
       
       
        Task<List<Student>> Get();
        Task<Student> Add(Student student);
        Task<Student> Update(Student student);
        Task<Student> Remove(int id);

    }
}
