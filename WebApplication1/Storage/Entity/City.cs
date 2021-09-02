using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Storage.Entity
{
    [Table("tblCity")]
    public class City : IUnicueIdentifiableEntity
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
        [Column("szPeople")]
        [MaxLength(50)]
        public int People { get; set; }

        [Required]
        [Column("gCountryForId")]
        public Guid CountryForId { get; set; }
        [ForeignKey(nameof(CountryForId))]
        public Country CountryFor { get; set; }
    }
}
