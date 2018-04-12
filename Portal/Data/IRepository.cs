using Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.DAO
{
    /// <summary>
    /// Interface de acceso a la base de datos.
    /// </summary>
    /// <typeparam name="T">Entidad</typeparam>
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);

        IQueryable<T> Find();

        T Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
