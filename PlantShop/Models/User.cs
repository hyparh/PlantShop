using Microsoft.AspNetCore.Identity;
using PlantShop.Data;
using System.ComponentModel.DataAnnotations;

namespace PlantShop.Models
{
    using static DataConstants.User;
    public class User : IdentityUser
    {
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; }

        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; }
    }
}
