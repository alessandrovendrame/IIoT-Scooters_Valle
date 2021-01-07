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
    public class ScooterRepository : IScooterRepository
    {
        public void insertData(EntityBase<ScooterConfiguration> entity, string connectionString)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Scooter (ScooterId,Brand,Company) " +
                "VALUES (@ScooterId,@Brand,@Company)";
                connection.Execute(query, entity);
            }
        }
    }
}
