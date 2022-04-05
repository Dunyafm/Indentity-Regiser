using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontProjectInAsp.Net.ViewModels.Admin.PosterViewModels
{
    public class PosterVM
    {
        public int Id { get; set; }
        //[Required]
        public List<IFormFile> Images { get; set; }
        public string Discount { get; set; }
        public string Cookie { get; set; }
        public string WeekCount { get; set; }



    }
}
