using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FreezarService
{
    [DataContract]
    public class Storage
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public double Quantity { get; set; }
        [DataMember]
        public string DisplayQuantity { get; set; }
        [DataMember]
        public string Unit { get; set; }
        [DataMember]
        public double MetricQuantity { get; set; }
        [DataMember]
        public string MetricDisplayQuantity { get; set; }
        [DataMember]
        public string MetricUnit { get; set; }
        [DataMember]
        public DateTime ExpectedUseBy { get; set; }
    }
}