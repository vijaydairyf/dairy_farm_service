//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dairy_farm_service
{
    using System;
    using System.Collections.Generic;
    
    public partial class FoodStock
    {
        public FoodStock()
        {
            this.FoodComsuptions = new HashSet<FoodComsuption>();
        }
    
        public int idFood { get; set; }
        public double quantityFood { get; set; }
        public string foodName { get; set; }
    
        public virtual ICollection<FoodComsuption> FoodComsuptions { get; set; }
    }
}