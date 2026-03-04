namespace PetRec.Application;

public interface IPetDatabase<T> where T : class
{
    public Task<List<T>> GetPetsAsync();
    public Task<int> AddPetAsync(T pet);
    public Task<int> DeletePetAsync(T pet);
    public Task<int> UpdatePetAsync(T pet);
    public Task DeleteAll();
}
