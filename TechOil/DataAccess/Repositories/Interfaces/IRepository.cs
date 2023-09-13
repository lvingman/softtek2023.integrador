namespace TechOil.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
            
        public Task<List<T>> GetAllActive();

        public Task<T> FindByID(int id);

        public Task<bool> Insert(T entity);

        public Task<bool> Update(T entity);
        public Task<bool> HardDelete(int id);
        public Task<bool> SoftDelete(int id);


    }
}
