using Microsoft.AspNetCore.Mvc;

namespace WebShopAPI.Models
{
    public class CreateProductModel
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public int brandId { get; set; }
        public int catId { get; set; }
        public string desc { get; set; }
        public string path { get; set; }
    }
}
