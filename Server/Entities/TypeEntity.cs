using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Entities;
[Table("Type")]
public class TypeEntity{
    [Key]
    public int id {get; set;}
    [Required]
    [MaxLength(50)]
    public string name {get; set;}
    public virtual ICollection<ProductEntity> productEntities{get; set;}
}