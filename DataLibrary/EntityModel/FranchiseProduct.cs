//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLibrary.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class FranchiseProduct
    {
        public int FranchiseProductId { get; set; }
        public int FranchiseId { get; set; }
        public int ProductId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatorId { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public int LastModifierID { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> DeleterID { get; set; }
    }
}
