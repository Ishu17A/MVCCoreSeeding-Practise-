using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCCorePractice.Models;

namespace MVCCorePractice.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {



        private AddDbContextFile _context ;
   
        private DbSet<T> _table ;


        public Repository(AddDbContextFile contextFile) { 
        this._context = contextFile;
          _table = contextFile.Set<T>();
        
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }
        public void Delete(object id)
        {
            T existing = _table.Find(id);

            _table.Remove(existing);
        }


        public T GetById(object id)
        {
            return _table.Find(id);
        }

        public void Insert(T obj)
        {
            _table.Add(obj);
            _context.SaveChanges();
        }

        public void Save()
        {

            _context.SaveChanges();
        }

        public void Update(T obj)
        {
          
            _table.Attach(obj);

            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
