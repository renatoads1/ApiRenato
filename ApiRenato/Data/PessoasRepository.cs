using System.Threading.Tasks;

namespace ApiRenato.Data
{
    public class PessoasRepository : IPessoasRepository
    {
        public readonly DAOContext _dAOContext;

        public PessoasRepository(DAOContext dAOContext)
        {
            _dAOContext = dAOContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _dAOContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _dAOContext.Remove(entity);
        }



        public void Update<T>(T entity) where T : class
        {
            _dAOContext.Update(entity);
        }

        public async Task<bool> SaveShangesAsync()
        {
            return (await _dAOContext.SaveChangesAsync() > 0);
        }
    }
}
