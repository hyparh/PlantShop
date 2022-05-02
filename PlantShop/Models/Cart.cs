using PlantShop.Models.Plants;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlantShop.Models
{
    public class Cart
    {
        public int Id { get; init; }


        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }


        [ForeignKey(nameof(Plant))]
        public string PlantId { get; set; }
        public Plant Plant { get; set; }
    }
}
