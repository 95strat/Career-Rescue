//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Career_Rescue.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employer()
        {
            this.Job_Listing = new HashSet<Job_Listing>();
        }
    
        public int Employer_id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string business_type { get; set; }
        public string Phone { get; set; }
        public string website { get; set; }
        public string status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_Listing> Job_Listing { get; set; }
    }
}