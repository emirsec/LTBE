using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lockthreat.Vendors
{
    [Table("VendorProductServices")]
    public  class VendorProductService : FullAuditedEntity<long>
    {
        public int? VendorServiceId  { get; set; }
        public DynamicPropertyValue VendorService { get; set; }

        public long? VendorId { get; set; }
        public Vendor Vendor { get; set; }


    }
}
