namespace TelemetryPortal_MVC.Repository_classes
{
    public interface IGenericRepository<E> where E : class
    {
        IEnumerable<E> GetAll();
        void Add(E entity);
        void Remove(E entity);
        void Update(E entity);
    }
}
