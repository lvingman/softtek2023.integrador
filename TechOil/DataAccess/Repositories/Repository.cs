using System.Net;
using Microsoft.EntityFrameworkCore;
using TechOil.DataAccess.Repositories.Interfaces;

namespace TechOil.DataAccess.Repositories
{

    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly TechOilDbContext _context;

        public Repository(TechOilDbContext context)
        {
            _context = context;
        }

        //Methods
        //List Items
        public virtual async Task<List<T>> GetAllActive()
        {   
            return await _context.Set<T>().ToListAsync();
        }
        
        //Find by Id
        public virtual async Task<T?> FindByID(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        //Insert data in the DB
        public virtual async Task<bool> Insert(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return true;
        }
        //Update data in DB
        public virtual async Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
        //Hard Delete in DB
        public virtual Task<bool> HardDelete(int id)
        {
            throw new NotImplementedException();
        }
        //Soft Delete in DB
        public virtual Task<bool> SoftDelete(int id)
        {
            throw new NotImplementedException();
        }


    }
        
}
       