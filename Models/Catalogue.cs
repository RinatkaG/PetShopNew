namespace PetShopNew.Models
{
    public class Category
    {
        public string? Name { get; set; }
        public int CategoryId { get; set; }
        public List<Animals>? allAnimals { get; set; }
    }
}
