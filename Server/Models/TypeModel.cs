using System.ComponentModel.DataAnnotations;

namespace Server.Models;

public class TypeModel{
    [Required]
    [MaxLength(50)]
    public string name {get; set;}
}