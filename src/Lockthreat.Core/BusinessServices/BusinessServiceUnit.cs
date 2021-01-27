using Abp.Domain.Entities.Auditing;
using Lockthreat.BusinessEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lockthreat.BusinessServices
{
    [Table("BusinessServiceUnits")]
    public class BusinessServiceUnit  : FullAuditedEntity<long>
    {
        public long? BusinessServiceId  { get; set; }
        public BusinessService BusinessService  { get; set; }
        public long? BusinessUnitId  { get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        
       
    }
}
