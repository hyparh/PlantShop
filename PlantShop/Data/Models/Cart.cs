using PlantShop.Models.Plants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlantShop.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; init; }

        [Required]
        public string UserId { get; set; }

        public ICollection<Plant> Plants { get; set; } = new List<Plant>();
    }
}
