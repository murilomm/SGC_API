using SGC_API.Core.Entity;

namespace SGC_API.Core.Interfaces.Services
{
    public interface ILoginService
    {
        Cliente Autenticar(string login, string senha);
    }
}
