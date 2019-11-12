using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Infrastructure.Data;

namespace SGC_API.Infrastructure.Repository
{
    public class UsuarioRepository : EFRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ClienteContext dbContext) : base(dbContext)
        {

        }        
    }
}
