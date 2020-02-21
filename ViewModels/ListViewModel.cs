using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcEFBootstrapAngular.ViewModels
{
    public class ListViewModel
    {
        public int IdModel { get; set; }
        public string BitchNameModel { get; set; }
        public int NumberModel { get; set; }
        public string TiTDescriptionModel { get; set; }

        public IFormFile ProfilePictureModel { get; set; }
    }
}
