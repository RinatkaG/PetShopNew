using System.ComponentModel.DataAnnotations;

namespace PetShopNew.Models
{
    public class TableAnimalsCommentscs
    {
        [Required]
        public int AnimalsId { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? PictureName { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public List<Animals> allAnimals { get; set; }

        [Display(Name = " Email address:")]
        [StringLength(50)]
        [RegularExpression(".+\\@.+\\..+")]
        public string? EmailAddress { get; set; }
        public int CommentsId { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(100)]
        public string? Comment { get; set; }
    }
}
