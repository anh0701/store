using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace Server.Entities;

[Table("Product")]
public class ProductEntity{
    [Key]
    public Guid id {get; set;}
    [Required]
    [MaxLength(100)]
    public string name {get; set;}
    public string detail {get; set;}
    [Range(0, double.MaxValue)]
    public double cost {get; set;}
    public byte discount {get; set;}
    public int? idType{get; set;}
    [ForeignKey("idType")]
    public TypeEntity type{get; set;}
}