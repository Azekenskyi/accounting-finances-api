using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Core
{
    public class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid Id { get; set; }

        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime UpdatedDate { get; set; }
        public virtual DateTime DeletedDate { get; set; }

        public virtual Guid CreatedBy { get; set; }
        public virtual Guid UpdatedBy { get; set; }
        public virtual Guid DeletedBy { get; set; }

        public virtual bool IsDeleted { get; set; } = false;
    }
}