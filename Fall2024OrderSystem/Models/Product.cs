using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fall2024OrderSystem.Models;

public class Product
{
    [Key]
    public int Id { get; set; } // sql identity column (also know as autoincrement field)
    // public int ProductId { get; set; }
    [MaxLength(250)]
    public string Name { get; set; } = null!;
    [Column(TypeName ="decimal(6,2)")]
    public decimal Price { get; set; }
}
