﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.Entities
{
    public class EntityBase : IEntityBase
    {
        public virtual Guid Id { get; set; }
        public virtual string CreatedBy { get; set; } = "Undefined";
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string? ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
    }
}
