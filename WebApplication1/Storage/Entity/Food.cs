using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Storage.Entity
{
    [Table("tblFood")]
    public class Food : IUnicueIdentifiableEntity
    {
        [Key]
        [Required]
        [Column("gId")]
        public Guid Id { get; set; }

        [Required]
        [Column("szName")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Column("szPrice")]
        [MaxLength(50)]
        public int Price { get; set; }

        [Required]
        [Column("gMenuForId")]
        public Guid MenuForId { get; set; }
        [ForeignKey(nameof(MenuForId))]
        public Menu MenuFor { get; set; }

    }
}
