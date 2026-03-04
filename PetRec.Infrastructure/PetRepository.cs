using PetRec.Application;
using PetRec.Domain;
using Utilities;
using Utilities.SaveSystem;

namespace PetRec.Infrastructure;

public class PetRepository : IPetRepository
{
    //public Task AddAsync(Pet pet)
    public void AddAsync(Pet pet)
    {
        ArraySaveSystem<Pet>.Append(pet);
    }

    //public Task<List<Pet>> GetAllAsync()
    //{
    //    throw new NotImplementedException();
    //}

    public Task UpdateAsync(Pet pet)
    {
        throw new NotImplementedException();
    }

    public List<Pet> GetAllAsync()
    {
        return ArraySaveSystem<Pet>.Load().ToList();
    }

    public void ClearAll()
    {
        ArraySaveSystem<Pet>.DeleteAllCache();
    }
}
