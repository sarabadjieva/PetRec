namespace PetRec.Core.Interfaces;

public interface IDatabase
{
    Task DropTableAsync<T>() where T : class, IDatabaseRecord, new();
    Task CreateTableAsync<T>() where T : class, IDatabaseRecord, new();
    Task<List<T>> GetAllAsync<T>() where T : class, IDatabaseRecord, new();
    Task AddAsync<T>(T entity) where T : class, IDatabaseRecord;
    Task DeleteAsync<T>(T record) where T : class, IDatabaseRecord;
    Task<int> UpdateAsync<T>(T record) where T : class, IDatabaseRecord;
    Task DeleteAllAsync<T>() where T : class, IDatabaseRecord;
}
