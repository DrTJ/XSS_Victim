//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XSS_Victim.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Posts
    {
        public int UserId { get; set; }
        public long PostId { get; set; }
        public System.DateTime PublishDateTime { get; set; }
        public bool IsPublished { get; set; }
        public string PostContent { get; set; }
        public bool HasFragments { get; set; }
    }
}
