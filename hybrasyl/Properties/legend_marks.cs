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
    
    public partial class legend_marks
    {
        public int id { get; set; }
        public int player_id { get; set; }
        public string prefix { get; set; }
        public int color { get; set; }
        public int icon { get; set; }
        public string text { get; set; }
        public bool @public { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
    
        public virtual player player { get; set; }
    }
}
