using System.ComponentModel.DataAnnotations;

namespace PetShopNew.Models
{
    public class Comments
    {
        [Display(Name =" Email address:")]
        [StringLength(50)]
        [RegularExpression(".+\\@.+\\..+")]
        public string?  EmailAddress{ get; set; }
        public int CommentsId { get; set; }
        public int AnimalsId { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(100)]
        public string? Comment { get; set; }
    }
}
