using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Storage.Entity
{
    [Table("tblMenu")]
    public class Menu : IUnicueIdentifiableEntity
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
        [Column("szSize")]
        [MaxLength(50)]
        public int Size { get; set; }

        [Required]
        [Column("gVerandaForId")]
        public Guid VerandaForId { get; set; }
        [ForeignKey(nameof(VerandaForId))]
        public Veranda VerandaFor { get; set; }
    }
}