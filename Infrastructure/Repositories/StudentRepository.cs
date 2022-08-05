namespace Infrastructure.Repositories
{
    using Application.Repositories;
    using Domain.Models;
    using I.Repositories;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Traning;

    public class StudentRepository : BaseReposirory<Student> , IStudentRepository
    {

        public StudentRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }
       

        public Task<Student> Add(Student entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Student> Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
