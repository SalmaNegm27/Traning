namespace Traning.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Traning.Models;

    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;
        public StudentRepository(AppDbContext appDbContext)
        {
            
            _context = appDbContext;
        }

        public async Task<List<Student>> Get()
        {
            return await _context.students.ToListAsync();
        }
        public async Task<Student> Add(Student student)
        {
           await  _context.students.AddAsync(student);
            await _context.SaveChangesAsync();
            return student;

        }
        public async Task<Student> Update(Student student)
        {
            if (_context.students.Any(student => student.Id == null))
                throw new Exception("student doesnot exist");
              _context.students.Update(student);
            await _context.SaveChangesAsync();
            return student;
        }


        public async Task<Student> Remove(int id)
        {
            Student student = _context.students.FirstOrDefault(x => x.Id == id);
            if (student == null)
                throw new Exception("student doesnot exist");
             _context.students.Remove(student);
            await _context.SaveChangesAsync();
            return student;


        }


    }
}
