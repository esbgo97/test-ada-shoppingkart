namespace ADA.ShoppingKart.Business
{
    public interface IEntityBusiness<T>
    {
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<T> Get(T entity);
        Task<List<T>> GetAll(T entity);
    }
}
