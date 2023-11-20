using System.Runtime.InteropServices;

namespace ControleDeChaves.Application.Services.Interfaces
{
    public interface IKeyService
    {
        Task<string> Create();
    }
}
