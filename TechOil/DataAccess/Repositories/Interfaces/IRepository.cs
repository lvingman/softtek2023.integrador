namespace TechOil.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
            
        public Task<List<T>> GetAll();

        public Task<T> FindByID(int id);

    }
}
