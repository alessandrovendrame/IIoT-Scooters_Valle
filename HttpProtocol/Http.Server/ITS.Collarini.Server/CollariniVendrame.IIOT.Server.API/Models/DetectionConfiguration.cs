using CollariniVendrame.IIOT.Server.API.ModelsStorageAzure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollariniVendrame.IIOT.Server.API.Models
{
    public class DetectionConfiguration : EntityBase<DetectionConfiguration>
    {
        public int SensorId { get; set; }
        public int ScooterId { get; set; }
        public string SensorValue { get; set; }
        public string SensorType { get; set; }
        public DateTime SensorDetectionDate { get; set; }

    }
}
