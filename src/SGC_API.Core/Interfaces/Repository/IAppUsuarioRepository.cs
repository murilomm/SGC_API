using SGC_API.Core.Entity;
using System.Linq;

namespace SGC_API.Core.Interfaces.Repository
{
    public interface IAppUsuarioRepository : IRepository<AppUsuario>
    {
        void Remover(int appId, int usuarioId);
    }
}
