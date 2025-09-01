using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DesafioDotnet.Dominio.Entidades;

public class Veiculo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;
    [Required]
    public string Nome { get; set; } = default!;
    [Required]
    public string Marca { get; set; } = default!;
    [Required]
    public int Ano { get; set; }   
}