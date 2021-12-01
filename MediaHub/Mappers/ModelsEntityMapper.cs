using System.Net.Mime;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using mediaimage.Entity;

namespace mediaimage.Mappers
{
    public static class ModelsEntityMapper
    {
        [Obsolete]
        public static Entity.NewImage ToEntity(NewImage image)
            => new Entity.NewImage () 
            {
                Title = image.Title,
                AltText = image.AltText,
                ContentType = image.ContentType,
                Data = image.Data
            };
       
        private static byte[] toByte(IFormFile image)
        {
            var memoryStream = new MemoryStream();
            image.CopyToAsync(memoryStream);
            var result = memoryStream.ToArray();
            return result;
        }
    }
}
