﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FreezarService
{
    [DataContract]
    public class UserStored
    {
        [DataMember]
        public string UserId { get; set; }

        [DataMember]
        public Ingredient IngredientId { get; set; }

        [DataMember]
        public double Amount { get; set; }

        [DataMember]
        public DateTime ExpectedUseBy { get; set; }

        [DataMember]
        public double Quantity { get; set; }
        [DataMember]
        public string DisplayQuantity { get; set; }
        [DataMember]
        public double MetricQuantity { get; set; }
        [DataMember]
        public string MetricDisplayQuantity { get; set; }

    }
}