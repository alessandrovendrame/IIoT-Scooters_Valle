using CollariniVendrame.IIOT.Server.API.ModelsStorageAzure;
using CollariniVendrame.IIOT.Server.API.ServiceStorageAzure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollariniVendrame.IIOT.Server.API.ServiceStorageSQL
{
    public interface IRepository <TEntity, TKey>
                   where TEntity : EntityBase<TKey>
    { 
        //IEnumerable<TEntity> getAllData();

        //TEntity getDataById(int id);

        void insertData(TEntity entity, string connectionString);

        //void deleteData(int id);

        //void Update(Customers Product);
    }
}
