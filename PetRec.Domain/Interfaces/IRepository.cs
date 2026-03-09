namespace PetRec.Core.Interfaces;

public interface IRepository<TDomain>
    where TDomain : class
{
    Task<List<TDomain>> GetAllAsync();
    Task AddAsync(TDomain entity);
    Task UpdateAsync(TDomain entity);
    Task DeleteAsync(TDomain entity);

    /// <summary>
    /// Use with caution, this will delete all pets in the database. This is intended for testing purposes only.
    /// </summary>
    /// <returns></returns>
    Task DeleteAll();
}
