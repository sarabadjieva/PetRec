using PetRec.Application;
using PetRec.Domain;

namespace PetRec.Infrastructure;

public class PetRepository : IPetRepository
{
    private readonly PetDatabase _database;

    public PetRepository(IPetDatabase<PetEntity> db)
    {
        _database = db as PetDatabase;
    }

    public async Task<List<Pet>> GetAllAsync()
    {
        var entities = await _database.GetPetsAsync();

        return entities.Select(e => new Pet
        {
            Id = (uint)e.Id,
            Name = e.Name,
            Type = e.Type,
            BirthDate = e.BirthDate
        }).ToList();
    }

    public async Task AddAsync(Pet pet)
    {
        var entity = new PetEntity
        {
            Name = pet.Name,
            Type = pet.Type,
            BirthDate = pet.BirthDate
        };

        await _database.AddPetAsync(entity);
    }

    public async Task UpdateAsync(Pet pet)
    {
        var entity = new PetEntity
        {
            Id = pet.Id,
            Name = pet.Name,
            Type = pet.Type,
            BirthDate = pet.BirthDate
        };

        await _database.UpdatePetAsync(entity);
    }

    public async Task DeleteAll()
    {
        await _database.DeleteAll();
    }
}
