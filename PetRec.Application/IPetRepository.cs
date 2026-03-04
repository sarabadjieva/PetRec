using PetRec.Domain;

namespace PetRec.Application;

public interface IPetRepository
{
    //Task<List<Pet>> GetAllAsync();
    List<Pet> GetAllAsync();
    void AddAsync(Pet pet);
    //Task AddAsync(Pet pet);
    Task UpdateAsync(Pet pet);
}
