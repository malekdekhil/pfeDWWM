using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domains
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }
        public string UrlImage { get; set; }
        public List<Product> products { get; set; }
    }
}
