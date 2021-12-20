using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace math.ViewModels
{
    public class NewPostViewModel
    {
        [Required(ErrorMessage = "Sarlavxani yozish shart!")]
        [DisplayName("Game")]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public string Content { get; set; }
        
        public string Tags { get; set; }
        
        public IFormFile HeaderImage { get; set; }
    }
}