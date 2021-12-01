using System.ComponentModel.DataAnnotations;

namespace mediaimage.Entity
{

    public class NewImage
    {
        [Required]
        [MinLength(1)]
        [MaxLength(5242880)]
        public byte[] Data { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        
        [MaxLength(255)]
        public string AltText { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string ContentType { get; set; }
                
    }
}