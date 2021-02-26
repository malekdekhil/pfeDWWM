using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domains
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        [Required]
        [Display(Name ="Nom de l'article")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Nom de réferencement")]
        public string SeoName { get; set; }
        [Required]

        [Display(Name = "Prix d'achat")]
        public decimal PurchasePrice { get; set; }
        [Required]
        [Display(Name = "Prix de vente")]

        public decimal SalesPrice { get; set; }
        [Display(Name = "Promotion")]

        public bool InPromo { get; set; }
        [Required]
        [Display(Name = "Courte description")]

        public string ShortDescription { get; set; }
        [Display(Name = "Longue description")]

        public string LongDescription { get; set; }
        [Display(Name = "lien de l'image")]

        public string ImageUrl { get; set; }
        [Required]
        [Display(Name = "Quantité")]

        public int Quantity { get; set; }
        [Required]
        [Display(Name = "Date de création")]

        public DateTime CreationDate { get; set; }
        [ForeignKey("Category")]
        [Display(Name = "Catégorie")]

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public List<Opinion> Opinions { get; set; }
    }
}
