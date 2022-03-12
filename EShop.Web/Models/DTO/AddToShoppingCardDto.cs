using EShop.Web.Models.Domain;

namespace EShop.Web.Models.DTO
{
    public class AddToShoppingCardDto
    {
        public Product SelectedProduct { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
