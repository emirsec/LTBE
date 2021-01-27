using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lockthreat.GrcPrograms 
{
    [Table("ProgramCountrys")]
    public class ProgramCountry  : FullAuditedEntity<long>
    {
        public long? GrcProgramId  { get; set; }

        public GrcProgram GrcProgram { get; set; }

        public int? CountryId { get; set; }
        public DynamicPropertyValue Country { get; set; }
    }
}
