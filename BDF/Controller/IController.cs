using System;
using System.Collections.Generic;
using System.Text;

namespace BDF.Controller
{
    public interface IController<T>
    {
        public IEnumerable<T> Read();
        public void Delete(int id);
        public void Create(T entity);
        public void Update(T entity);
        public T Find(int id);
    }
}
