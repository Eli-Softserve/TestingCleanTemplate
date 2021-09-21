using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    public class AuditableEntity
    {
        public DateTime dtAdded { get; set; }
        public DateTime dtEdited { get; set; }
        public string strAddedBy { get; set; } // this should be an id
        public string strEdited { get; set; } // this should be an id
        public Guid gGuid { get; set; }
        public bool bIsDeleted { get; set; }
    }
}
