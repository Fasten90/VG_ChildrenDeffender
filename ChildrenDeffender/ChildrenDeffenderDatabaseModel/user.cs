//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChildrenDeffenderDatabaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string ProfilType { get; set; }
        public Nullable<bool> HasPassword { get; set; }
        public Nullable<decimal> Age { get; set; }
        public string Sex { get; set; }
        public Nullable<int> ManyLogged { get; set; }
        public Nullable<System.DateTime> DateLastLogged { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
    }
}
