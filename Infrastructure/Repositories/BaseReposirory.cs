namespace Infrastructure.Repositories
{
    using Application.Repositories;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Traning;

    public abstract class BaseReposirory<T> : IbaseRepository<T> where T : class
    {
        protected AppDbContext _appDbContext;
        public BaseReposirory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext; 
        }

        public async Task<T> GetById(int id)
        {
          return  await _appDbContext.Set<T>().FindAsync(id);
        }
        public async Task<List<T>> GetAll()
        {
            return await _appDbContext.Set<T>().ToListAsync();
        }
        public  async Task Add(T entity)
        {
             await _appDbContext.Set<T>().AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            
        }

        public async Task Edit(T entity)
        {

            _appDbContext.Set<T>().Update(entity);
            await  _appDbContext.SaveChangesAsync();
        }
        public async Task Delete(T entity)
        {
            _appDbContext.Set<T>().Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }

        
    }
}
