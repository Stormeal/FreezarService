using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FreezarService
{
    [DataContract]
    public class Ingredient
    {
        [DataMember]
        public int IngredientId { get; set; }
        [DataMember]
        public int DisplayIndex { get; set; }
        [DataMember]
        public bool isHeading { get; set; }
        [DataMember]
        public string Name { get; set; }
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
        public string Department { get; set; }
        [DataMember]
        public bool UsuallyOnHand { get; set; }

    }
}