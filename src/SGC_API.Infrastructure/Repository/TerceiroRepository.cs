using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Infrastructure.Data;

namespace SGC_API.Infrastructure.Repository
{
    public class TerceiroRepository : EFRepository<Terceiro>, ITerceiroRepository
    {
        public TerceiroRepository(ClienteContext dbContext) : base(dbContext)
        {

        }
    }
}
