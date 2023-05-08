using System.ComponentModel.DataAnnotations;

namespace BlazorWebShop.Model
{
    public class ProductBlazorModel
    {

        [Required]
        [StringLength(32, ErrorMessage = "Identifier too long (32 character limit).")]
        public string? Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int BrandId { get; set; }

        [Required]
        public int CatId { get; set; }

        [Required]
        public string? Desc { get; set; }

        [Required]
        public string? Path { get; set; }

    }
}
