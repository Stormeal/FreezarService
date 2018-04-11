using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FreezarService
{
    [DataContract]
    public class Recipe
    {
        [DataMember]
        public int RecipeId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Cusine { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string SubCategory { get; set; }
        [DataMember]
        public int StarRating { get; set; }
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