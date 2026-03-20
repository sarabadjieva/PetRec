using PetRec.Core.Interfaces;
using PetRec.Infrastructure.Records;

namespace PetRec.Infrastructure.Repositories;

public interface IPetRepository : IRepository<IPet>
{
}

internal class PetRepository(IDatabase db)
    : RepositoryBase<IPet, PetRecord>(db), IPetRepository
{
    protected override PetRecord ToRecord(IPet domain) =>
        new()
        {
            //Id = domain.Id,
            Name = domain.Name,
            Type = domain.Type,
            BirthDate = domain.BirthDate,
            ImagePath = domain.ImagePath
        };
}
