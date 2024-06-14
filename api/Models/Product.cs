using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public bool IsAvailable { get; set; }
        public string Brand { get; set; }
        public int Discount { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public Category Categorie { get; set; }
    }
}