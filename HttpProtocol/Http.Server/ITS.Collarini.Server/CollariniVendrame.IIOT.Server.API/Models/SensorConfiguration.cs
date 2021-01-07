using CollariniVendrame.IIOT.Server.API.ModelsStorageAzure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollariniVendrame.IIOT.Server.API.Models
{
    public class SensorConfiguration : EntityBase<SensorConfiguration>
    {
        public int SensorId { get; set; }
        public string SensorType { get; set; }
        public string SensorMesurementUnit { get; set; }
    }
}
