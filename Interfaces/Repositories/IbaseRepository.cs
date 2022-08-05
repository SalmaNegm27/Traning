namespace Application.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IbaseRepository<T>
    {
        Task<List<T>> Get();
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
