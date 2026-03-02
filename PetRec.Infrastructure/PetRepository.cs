using PetRec.Application;
using PetRec.Domain;

namespace PetRec.Infrastructure;

public class PetRepository : IPetRepository
{
    public Task AddAsync(Pet pet)
    {
        throw new NotImplementedException();
    }

    public Task<List<Pet>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Pet pet)
    {
        throw new NotImplementedException();
    }
}
