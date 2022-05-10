using System.ComponentModel.DataAnnotations;

namespace PlantShop.Models.Plants
{
    public class Plant
    {
        public int Id { get; init; }

        [Required]
        [Display(Name = "Изображение:")]
        public string ImageUrl { get; set; }

        [Required]
        [Display(Name = "Име:")]
        public string Name  { get; set; }

        [Required]
        [Display(Name = "Възраст:")]
        public double Age { get; set; }

        [Display(Name = "Цена:")]
        public decimal Price { get; set; }
    }
}
