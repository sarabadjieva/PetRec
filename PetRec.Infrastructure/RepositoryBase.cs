using PetRec.Application;

namespace PetRec.Infrastructure;

internal abstract class RepositoryBase<TDomain, TRecord> : IRepository<TDomain> 
    where TDomain : class
    where TRecord : class, IDatabaseRecord, new()
{
    private readonly IDatabase _database;

    public RepositoryBase(IDatabase db)
    {
        _database = db;
        _database.DropTableAsync<TRecord>();
        _database.CreateTableAsync<TRecord>().Wait();
    }

    protected abstract TDomain ToDomain(TRecord record);
    protected abstract TRecord ToRecord(TDomain domain);

    public async Task<List<TDomain>> GetAllAsync()
    {
        var entities = await _database.GetAllAsync<TRecord>();

        return entities.Select(ToDomain).ToList();
    }

    public async Task AddAsync(TDomain entity)
    {
        await _database.AddAsync(ToRecord(entity));
    }

    public async Task UpdateAsync(TDomain entity)
    {
        await _database.UpdateAsync(ToRecord(entity));
    }

    public async Task DeleteAsync(TDomain entity)
    {
        await _database.DeleteAsync(ToRecord((entity)));
    }

    public async Task DeleteAll()
    {
        await _database.DeleteAllAsync<TRecord>();
    }
}
