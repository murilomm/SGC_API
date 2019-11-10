using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Infrastructure.Data;

namespace SGC_API.Infrastructure.Repository
{
    public class AppRepository : EFRepository<App>, IAppRepository
    {
        public AppRepository(ClienteContext dbContext) : base(dbContext)
        {

        }
    }
}
