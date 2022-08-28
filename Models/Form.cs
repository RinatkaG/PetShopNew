using System.ComponentModel.DataAnnotations;

namespace PetShopNew.Models
{
    public class Form
    {
        [Display( Name = "Please fill your user name:")]
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        public int Password { get; set; }
    }
}
