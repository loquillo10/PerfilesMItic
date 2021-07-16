using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPWEB.Models
{
    public class imagenes
    {
        public IFormFile url { get; set; }
        public string Nombre { get; set; }
    }
}
