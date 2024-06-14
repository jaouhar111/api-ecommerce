using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public List<Product> Products { get; set; } = new List<Product>();
    }
}