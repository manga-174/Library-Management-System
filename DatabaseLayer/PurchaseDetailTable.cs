//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseDetailTable
    {
        public int PurchaseDetailsID { get; set; }
        public int BookID { get; set; }
        public int PurchaseID { get; set; }
        public int Qty { get; set; }
        public double UnitPrice { get; set; }
    
        public virtual BookTable BookTable { get; set; }
        public virtual BookTable BookTable1 { get; set; }
        public virtual PurchaseTable PurchaseTable { get; set; }
        public virtual PurchaseTable PurchaseTable1 { get; set; }
    }
}
