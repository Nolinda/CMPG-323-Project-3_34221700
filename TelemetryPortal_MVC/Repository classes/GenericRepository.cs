using System.Collections;
using System.Linq.Expressions;
using TelemetryPortal_MVC.Data;

namespace TelemetryPortal_MVC.Repository_classes
{
    public class GenericRepository<E> : IGenericRepository<E> where E : class
    {
        protected readonly TechtrendsContext _context;
        public GenericRepository(TechtrendsContext context)
        {
            _context = context;
        }

        public void Add(E entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Add)} entity must not be null");
            }
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException($"{nameof(entity)} could not be saved: {ex.Message}");
            }
           
        }

        public IEnumerable<E> GetAll()
        {

            try
            {
                return _context.Set<E>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not retrieve entities: {ex.Message}");
            }
        }

        public void Remove(E entity)
        {
            try
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not be remove entity: {ex.Message}");
            }
        }

        public void Update(E entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Add)} entity must not be null");
            }
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}
