
namespace Domain.Interface
{
    public interface IGeneralRepository<T> where T : BaseModelEntity
    {
        public IQueryable<T> GetAll();
        public Task<T> GetByID(int id);
        public Task<T> GetByIDWithTracking(int id);
        public Task Add(T entity);
        public Task<bool> IsExist(int id);


        public Task Update(T entity);
        public Task Delete(int id);
        public void UpdateInclude(T entity , params string[] modifiedParams);

    }
}
