using ControleDeChaves.Application.InputModels;
using ControleDeChaves.Domain.Entities;

namespace ControleDeChaves.Application.Services.Interfaces
{
    public interface IDeliveryService
    {
        Task<string> CreatePerson(Person model);
    }
}
