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
    
    public partial class SitePageFragments
    {
        public int PageID { get; set; }
        public int FragmentIndex { get; set; }
        public string PageContent { get; set; }
    
        public virtual SitePages SitePages { get; set; }
    }
}
