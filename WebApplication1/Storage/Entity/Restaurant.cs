using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Storage.Entity
{
    [Table("tblRestaurant")]
    public class Restaurant : IUnicueIdentifiableEntity
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
        [Column("szStars")]
        [MaxLength(50)]
        public int Stars { get; set; }

        [Required]
        [Column("gCityForId")]
        public Guid CityForId { get; set; }
        [ForeignKey(nameof(CityForId))]
        public City CityFor { get; set; }
    }
}
