//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coffee.RepositoryData
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Inventory
    {
        public int id { get; set; }
        public string inventoryType { get; set; }
        public Nullable<int> initialQty { get; set; }
        public Nullable<int> remainingQty { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> modifyDate { get; set; }
    }
}
