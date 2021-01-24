using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebCountry.Models
{
    public class Translation
    {
        public string de { get; set; }
        [Key]
        public string es { get; set; }
        public string fr { get; set; }
        public string ja { get; set; }
        public string it { get; set; }
        public string br { get; set; }
        public string pt { get; set; }
        public string nl { get; set; }
        public string hr { get; set; }
        public string fa { get; set; }
    }
}