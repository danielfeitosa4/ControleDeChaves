using ControleDeChaves.Application.Services.Interfaces;
using ControleDeChaves.Domain.Entities;
using ControleDeChaves.Infrastructure.Persistence;

namespace ControleDeChaves.Application.Services.Implementations
{
    public class DeliveryService : IDeliveryService
    {
        private readonly ControleDeChavesDbContext _dbContext;
        public DeliveryService(ControleDeChavesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> CreatePerson(Person model)
        {
            var person = new Person(model.Id, model.Name, model.Sector, model.Registration);

            await _dbContext.Persons.AddAsync(person);
            await _dbContext.SaveChangesAsync();

            return "Uma nova pessoa foi cadastrada com sucesso!";
        }

    }
}
