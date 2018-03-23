using System;
using System.Linq;
using System.Linq.Expressions;

namespace BlogApp.Repository
{
    public class BlogRepository<C, T> : IRepository<T> where T : BaseModel
    {
        private BlogAppDbContext context = new BlogAppDbContext();
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity is null");

            var result = context.Set<T>().FirstOrDefault(t => t.ID == entity.ID);

            if (result == null)
                return;

            context.Set<T>().Remove(result);
            Save();
        }

        public void Edit(T entity)
        {
            Save();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            var find = context.Set<T>().Where(predicate);
            return find;
        }

        public IQueryable<T> GetAll()
        {
            var get = context.Set<T>();
            return get;
        }

        public T GetSingle(int id)
        {
            var single = context.Set<T>().FirstOrDefault(c => c.ID == id);
            return single;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
