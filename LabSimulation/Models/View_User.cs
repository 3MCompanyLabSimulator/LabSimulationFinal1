//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabSimulation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class View_User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string SchoolName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsPremiumAccount { get; set; }
        public Nullable<int> SchoolID { get; set; }
        public string UserType { get; set; }
    }
}
