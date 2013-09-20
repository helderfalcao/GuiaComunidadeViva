using comunidadeViva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comunidadeViva.Models.Base
{

    public class BaseDao<T> where T : class
    {
        public abstract bool canSave(T entity);

        public void save(T entity)
        {
            if (canSave(entity))
            {
                getContext().Set<T>().Add(entity);
                getContext().SaveChanges();
            }
        }

        public abstract T reload(int code);

        public void delete(T entity)
        {
            getContext().Set<T>().Remove(entity);
            getContext().SaveChanges();
        }

        private DBComunidadeVivaContext context = null;

        public DBComunidadeVivaContext getContext()
        {
            if (context == null)
            {
                context = new DBComunidadeVivaContext();
            }
            return context;
        }

        public System.Data.Entity.DbSet<T> List
        {
            get
            {
                return context.Set<T>();
            }

        }
    }

}