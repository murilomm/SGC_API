using Microsoft.EntityFrameworkCore;
using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Infrastructure.Data;
using System.Linq;

namespace SGC_API.Infrastructure.Repository
{
    public class AppUsuarioRepository : EFRepository<AppUsuario>, IAppUsuarioRepository
    {
        public AppUsuarioRepository(ClienteContext dbContext) : base(dbContext)
        {

        }

        public void Remover(int appId, int usuarioId)
        {
            var entity = _dbContext.Set<AppUsuario>().Where(_ => _.AppId == appId && _.UsuarioId == usuarioId).FirstOrDefault();
            _dbContext.Set<AppUsuario>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
