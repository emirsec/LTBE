using Abp.Domain.Entities.Auditing;
using Lockthreat.ITServices;

namespace Lockthreat.BusinessServices
{
    public class BusinessITService : FullAuditedEntity<long>
    {
        public long? BusinessProcessId { get; set; }
        public BusinessService  BusinessService { get; set; }

        public long? ITServiceId  { get; set; }

        public ITService ITService  { get; set; }




    }
}
