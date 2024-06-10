using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YeniProje.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name ="ürün Adı")]

        public string? ProductName { get; set; } = string.Empty;
        [Display(Name = "ürün kodu")]

        public string? ProductCode { get; set; }
        [Display(Name = "ürün Açıklaması")]

        public string? ProductDescription { get; set; } = string.Empty;
        [Display(Name = "ürün Resmi")]

        public string? ProductPicture { get; set; }
        [Display(Name = "ürün Fiyatı")]

        public string? ProductPrice { get; set; }
        [Display(Name = "ürün kategorisi")]

        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        [NotMapped]
        public IFormFile? ImageUpload { get; set; }
    }
}
