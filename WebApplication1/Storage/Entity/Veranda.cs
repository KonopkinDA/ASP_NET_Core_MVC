using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Storage.Entity
{
    [Table("tblVeranda")]
    public class Veranda : IUnicueIdentifiableEntity
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
        [Column("szYearTime")]
        [MaxLength(50)]
        public string YearTime { get; set; }

        [Required]
        [Column("gRestaurantForId")]
        public Guid RestaurantForId { get; set; }
        [ForeignKey(nameof(RestaurantForId))]
        public Restaurant RestaurantFor { get; set; }
    }
}
