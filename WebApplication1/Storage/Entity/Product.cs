using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Storage.Entity
{
    [Table("tblProduct")]
    public class Product : IUnicueIdentifiableEntity
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
        [Column("szTime")]
        [MaxLength(50)]
        public int Time { get; set; }

        [Required]
        [Column("gFoodForId")]
        public Guid FoodForId { get; set; }
        [ForeignKey(nameof(FoodForId))]
        public Food FoodFor { get; set; }

    }
}
