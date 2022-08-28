using System.ComponentModel.DataAnnotations;

namespace PetShopNew.Models
{
    public class Animals
    {
        [Required]
        public int AnimalsId { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? PictureName { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public List<Animals> allAnimals { get; set; }
    }
}
