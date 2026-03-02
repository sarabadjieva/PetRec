using PetRec.Domain;

namespace PetRec.Application;

public interface IPetRepository
{
    Task<List<Pet>> GetAllAsync();
    Task AddAsync(Pet pet);
    Task UpdateAsync(Pet pet);
}
