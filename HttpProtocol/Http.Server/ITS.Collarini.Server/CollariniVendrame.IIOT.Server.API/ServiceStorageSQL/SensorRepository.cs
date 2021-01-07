using CollariniVendrame.IIOT.Server.API.Models;
using CollariniVendrame.IIOT.Server.API.ModelsStorageAzure;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CollariniVendrame.IIOT.Server.API.ServiceStorageSQL
{
    public class SensorRepository : ISensorRepository
    {
        public void insertData(EntityBase<SensorConfiguration> entity, string connectionString)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Sensor (SensorId,SensorType,SensorMesurementUnit) " +
                "values (@SensorId,@SensorType,@SensorMesurementUnit)";
                connection.Execute(query, entity);
            }
        }
    }
}
