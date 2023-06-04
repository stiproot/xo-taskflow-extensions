internal interface IService
{
    Task<long> GetLongAsync(string query);
}

internal interface IGenericService<T>
{
    Task<T> GetGenericTypeAsync(string query);
}