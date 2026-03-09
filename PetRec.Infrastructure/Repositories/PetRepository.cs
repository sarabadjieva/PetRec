using PetRec.Core.Interfaces;
using PetRec.Core.Entities;
using PetRec.Infrastructure.Records;

namespace PetRec.Infrastructure.Repositories;

public interface IPetRepository : IRepository<IPet>
{
}

internal class PetRepository : RepositoryBase<IPet, PetRecord>, IPetRepository
{
    public PetRepository(IDatabase db) : base(db)
    {
    }

    protected override IPet ToDomain(PetRecord record) =>
        new Pet
        {
            Id = record.Id,
            Name = record.Name,
            Type = record.Type,
            BirthDate = record.BirthDate,
            ImagePath = record.ImagePath
        };

    protected override PetRecord ToRecord(IPet domain) =>
        new PetRecord 
        {
            //Id = domain.Id,
            Name = domain.Name,
            Type = domain.Type,
            BirthDate = domain.BirthDate,
            ImagePath = domain.ImagePath
        };
}
