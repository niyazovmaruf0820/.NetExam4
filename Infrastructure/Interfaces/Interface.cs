namespace Infrastructure.Interfaces;

public interface Interface<T>
{
    Task<List<T>> GetValuesAsync();
    Task AddValueAsync(T value);
    Task UpdateValueAsync(T value);
    Task DeleteValueAsync(int id);
}
