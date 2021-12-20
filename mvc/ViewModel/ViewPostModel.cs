using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mvc.ViewModels
{

    public class ViewPostModel
    {
        [Required(ErrorMessage = "Sarlavxani yozish shart!")]
        [DisplayName("Sarlavxa")]
        // [MaxLength(5, ErrorMessage = "5 ta belgidan oshmasin!")]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public string Content { get; set; }
        
        public string Tags { get; set; }
        
        public IFormFile HeaderImage { get; set; }
    }
}