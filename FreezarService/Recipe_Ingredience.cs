﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FreezarService
{
    [DataContract]
    public class Recipe_Ingredience
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int RecipeId { get; set; }
        [DataMember]
        public int IngredientId { get; set; }
        [DataMember]
        public string Unit { get; set; }
        [DataMember]
        public double Quantity { get; set; }
        [DataMember]
        public string DisplayQuantity { get; set; }
        [DataMember]
        public double MetricQuantity { get; set; }
        [DataMember]
        public double MetricDisplayQuantity { get; set; }
        [DataMember]
        public string MetricUnit { get; set; }
    }
}