using PetRec.Application;
using SQLite;

namespace PetRec.Infrastructure;

public class PetDatabase : IPetDatabase<PetEntity>
{
    private readonly SQLiteAsyncConnection _database;

    public PetDatabase(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<PetEntity>().Wait();
    }

    public Task<List<PetEntity>> GetPetsAsync()
        => _database.Table<PetEntity>().ToListAsync();

    public Task<int> AddPetAsync(PetEntity pet)
        => _database.InsertAsync(pet);

    public Task<int> DeletePetAsync(PetEntity pet)
        => _database.DeleteAsync(pet);

    public Task<int> UpdatePetAsync(PetEntity pet)
        => _database.UpdateAsync(pet);

    public Task DeleteAll()
        => _database.DeleteAllAsync<PetEntity>();
}