using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lockthreat.AuthoratativeDocuments
{

    [Table("AuthoratativeDocuments")]

    public class AuthoratativeDocument : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public string AuthorityDocumentId { get; set; }

        public string AuthorityDocumentOrigin { get; set; }

        public string AuthoratativeDocumentTitle { get; set; }

        public int? MandateTypeId { get; set; }

        public DynamicPropertyValue MandateType { get; set; }

        public int? TypeId { get; set; }

        public DynamicPropertyValue Type { get; set; }

        public string Keyword { get; set; }

        public string AuthoratativeDocumentName { get; set; }

        public string DocumentURL { get; set; }

        public string Logo { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public string Notes { get; set; }

        public string ImportantNotice { get; set; }
    }
}
