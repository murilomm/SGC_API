using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Infrastructure.Data;
using System.Linq;

namespace SGC_API.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ClienteContext dbContext) : base(dbContext)
        {

        }

        public Cliente ObterPorLoginSenha(string cpf, string senha)
        {
            return _dbContext.Set<Cliente>().Where(_ => _.Cpf == cpf && _.Senha == senha).FirstOrDefault();
        }
    }
}
