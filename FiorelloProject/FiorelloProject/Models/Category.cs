using FiorelloProject.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace FiorelloProject.Models
{
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        
    }
}
