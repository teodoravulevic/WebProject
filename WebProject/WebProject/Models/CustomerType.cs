using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class CustomerType
    {
        public string Name { get; set; }
        public int DiscountPercentage { get; set; }
        public int MinimumPointsRequered { get; set; }

        public CustomerType(string name, int discountPercentage, int minimumPointsRequered)
        {
            Name = name;
            DiscountPercentage = discountPercentage;
            MinimumPointsRequered = minimumPointsRequered;
        }
    }
}