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
        public virtual async Task<List<T>> GetAll()
        {   
            return await _context.Set<T>().ToListAsync();
        }
        
        //Find by Id
        public virtual async Task<T> FindByID(int id)
        {
            return null;
            //TODO: Corregir esto como lo dijo el profe en Slack
            //return await _context.Set<T>().FirstAsync(x => x.Id == id);
        }


        
        
    }
        
}
       