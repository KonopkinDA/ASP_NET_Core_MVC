using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Storage
{
    public interface IUnicueIdentifiableEntity
    {
        [Key]
        [Required]
        [Column("gId")]
        public Guid Id { get; set; }
    }
}
