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
    
    public partial class LoginDetail
    {
        public int LoginId { get; set; }
        public string LoginEmail { get; set; }
        public string LoginPassword { get; set; }
        public string LoginPasswordSalt { get; set; }
        public int LoginPasswordEncryptType { get; set; }
        public System.DateTime LoginPasswordUpdateDate { get; set; }
        public string LoginUserFirstName { get; set; }
        public string LoginUserLastName { get; set; }
        public string LoginUserMobile { get; set; }
        public bool LoginLocked { get; set; }
        public bool LoginActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatorId { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public int LastModifierID { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> DeleterID { get; set; }
        public string LoginUserFullName { get; set; }
    }
}
