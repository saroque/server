//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hybrasyl.Properties
{
    using System;
    using System.Collections.Generic;
    
    public partial class reactor
    {
        public int id { get; set; }
        public string name { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
        public int map_id { get; set; }
        public int map_x { get; set; }
        public int map_y { get; set; }
        public string script_name { get; set; }
        public bool blocking { get; set; }
    
        public virtual map map { get; set; }
    }
}
