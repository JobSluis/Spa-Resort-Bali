//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Spa_Resort_bali.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lodges
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lodges()
        {
            this.Bookings = new HashSet<Bookings>();
        }
    
        public int LodgeId { get; set; }
        public int LodgeTypeId { get; set; }
        public int AdresId { get; set; }
        public string Code { get; set; }
        public bool Disabled { get; set; }
    
        public virtual Addresses Addresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bookings> Bookings { get; set; }
        public virtual LodgeTypes LodgeTypes { get; set; }
    }
}