//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab4_1.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssetHolder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssetHolder()
        {
            this.AccountAssets = new HashSet<AccountAsset>();
        }
    
        public System.Guid AssetHolderID { get; set; }
        public string CompanyName { get; set; }
        public long AvailaibleTokens { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountAsset> AccountAssets { get; set; }
    }
}
