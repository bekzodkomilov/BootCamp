using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace telegraf.ViewModels
{

        public class NewPostViewModel
        {
            [Required(ErrorMessage = "Sarlavxani yozish shart!")]
            [DisplayName("Sarlavxa")]
            public string Title { get; set; }
            
            public string Description { get; set; }
            
            public string Content { get; set; }
            
            public string Tags { get; set; }
            
            public IFormFile HeaderImage { get; set; }
        }
}