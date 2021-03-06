using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic constraint where T:class 
    //class: referans tip
    //IEntity: IEntity veya IEntity implemente eden bir class olabilir
    //new(): Interface classları new lenemez.
    public interface IEntityRepository<T> where T:class, IDto, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
