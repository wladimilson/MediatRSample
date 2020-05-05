using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatRSample.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);

        Task<T> Add(T item);

        Task Edit(T item);

        Task Delete(int id);
    }
}