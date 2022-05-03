using PlantShop.Models.Plants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlantShop.Models
{
    public class Cart
    {        
        [Key]
        public string Id { get; set; } = new Guid().ToString();

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }


        [ForeignKey(nameof(Plant))]
        public int PlantId { get; set; }
        public Plant Plant { get; set; }
    }
}
