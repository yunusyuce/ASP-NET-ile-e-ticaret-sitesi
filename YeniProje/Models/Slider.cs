using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YeniProje.Models
{
    public class Slider
    {
        [Key]
        public int SliderId {  get; set; }  
        
        public string? SliderName { get; set; } = string.Empty;

        public string? Header1 { get; set; } = string.Empty;

        public string? Header2 { get; set; } = string.Empty;

        public string? Context { get; set; } = string.Empty;

        public string? SliderImage { get; set; } = string.Empty;
        [NotMapped]

        public IFormFile? ImageUpload { get; set; }   
    }
}
