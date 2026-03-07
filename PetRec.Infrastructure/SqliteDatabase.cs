using PetRec.Application;
using SQLite;

namespace PetRec.Infrastructure;

internal class SqliteDatabase : IDatabase
{
    private readonly SQLiteAsyncConnection _connection;

    public SqliteDatabase(IAppDataPathProvider pathProvider)
    {
        _connection = new SQLiteAsyncConnection(pathProvider.GetDatabasePath());
    }

    /// <summary>
    /// USE WITH CAUTION! This will drop the table and all data in it. Use only for testing or when you are sure you want to lose all data in the table.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public Task DropTableAsync<T>()
        where T : class, IDatabaseRecord, new()
    {
        return _connection.DropTableAsync<T>();
    }

    public Task CreateTableAsync<T>()
        where T : class, IDatabaseRecord, new()
    {
        return _connection.CreateTableAsync<T>();
    }

    public Task<List<T>> GetAllAsync<T>()
        where T : class, IDatabaseRecord, new()
    {
        return _connection.Table<T>().ToListAsync();
    }

    public Task AddAsync<T>(T entity)
        where T : class, IDatabaseRecord
    {
        return _connection.InsertAsync(entity);
    }

    public Task DeleteAsync<T>(T entity)
        where T : class, IDatabaseRecord
    {
        return _connection.DeleteAsync(entity);
    }

    public Task<int> UpdateAsync<T>(T record)
        where T : class, IDatabaseRecord
    {
        return _connection.UpdateAsync(record);
    }

    public Task DeleteAllAsync<T>()
        where T : class, IDatabaseRecord
    {
        return _connection.DeleteAllAsync<T>();
    }
}