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
    
    public partial class HISTORIQUE_MALADIE
    {
        public string IDBOVIN { get; set; }
        public int ID_MALADIE { get; set; }
        public System.DateTime STARTMALADIE { get; set; }
        public Nullable<System.DateTime> END_MALADIE { get; set; }
        public Nullable<bool> VISITE_VETERINAIRE { get; set; }
    
        public virtual BOVIN BOVIN { get; set; }
        public virtual MALADIE MALADIE { get; set; }
    }
}
