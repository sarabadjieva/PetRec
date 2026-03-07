using PetRec.Application;
using PetRec.Domain;
using PetRec.Infrastructure.Records;

namespace PetRec.Infrastructure.Repositories;

public interface IPetRepository : IRepository<Pet>
{
}

internal class PetRepository : RepositoryBase<Pet, PetRecord>, IPetRepository
{
    public PetRepository(IDatabase db) : base(db)
    {
    }

    protected override Pet ToDomain(PetRecord record) =>
        new Pet
        {
            Id = record.Id,
            Name = record.Name,
            Type = record.Type,
            BirthDate = record.BirthDate
        };

    protected override PetRecord ToRecord(Pet domain) =>
        new PetRecord 
        {
            Id = domain.Id,
            Name = domain.Name,
            Type = domain.Type,
            BirthDate = domain.BirthDate
        };
}
