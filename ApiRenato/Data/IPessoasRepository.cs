using System.Threading.Tasks;

namespace ApiRenato.Data
{
    public interface IPessoasRepository
    {
        //generic
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveShangesAsync();
    }
}