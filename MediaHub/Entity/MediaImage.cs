using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mediahub.Entity
{

    public class MediaImage
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; } = Guid.NewGuid();
        
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
        
        [Obsolete("you shoud do this.")]
        public MediaImage()
        {
        }

        internal object Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}