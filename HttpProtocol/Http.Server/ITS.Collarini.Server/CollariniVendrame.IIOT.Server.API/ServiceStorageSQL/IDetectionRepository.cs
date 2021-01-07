using CollariniVendrame.IIOT.Server.API.Models;
using CollariniVendrame.IIOT.Server.API.ModelsStorageAzure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollariniVendrame.IIOT.Server.API.ServiceStorageSQL
{
    public interface IDetectionRepository : IRepository<EntityBase<DetectionConfiguration>, DetectionConfiguration>
    {
    }
}
