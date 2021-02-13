using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Expression =  (p=>p.CategoryId==2)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// 
    //Generic constrait
    //class : referans tip
    //IEntity olabilir yada IEntity den implemente olan bir class olabilir
    //new() : newlenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
