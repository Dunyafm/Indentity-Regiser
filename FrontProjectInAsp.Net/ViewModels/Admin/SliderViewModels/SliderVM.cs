using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrontProjectInAsp.Net.ViewModels.Admin
{
    public class SliderVM
    {
        public string Image { get; set; }
        [NotMapped]
        [Required]
        public List<IFormFile> Photos { get; set; }
    }
}
