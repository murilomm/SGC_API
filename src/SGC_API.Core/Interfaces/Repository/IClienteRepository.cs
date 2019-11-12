using SGC_API.Core.Entity;

namespace SGC_API.Core.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorLoginSenha(string cpf, string senha);
    }
}
