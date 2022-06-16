using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  class Coordenador
  {
    public int CoordenadorId { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Nome { get; set; }

    [Column(TypeName = "varchar(15)")]
    public string Telefone { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string Email { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string Endereco { get; set; }

    public virtual ICollection<Curso> Cursos { get; set; }
  }
}