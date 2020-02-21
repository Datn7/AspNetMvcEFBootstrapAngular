using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcEFBootstrapAngular.Data.Entities
{
    

    public class Item
    {
        public int Id { get; set; }
        public string BitchName { get; set; }
        public int Number { get; set; }
        public string TiTDescription { get; set; }

        public string ProfilePicture { get; set; }


    }
}
