using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  class Professor
  {
    public int ProfessorId { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Nome { get; set; }

    [Column(TypeName = "varchar(15)")]
    public string Telefone { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string Email { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string Endereco { get; set; }

    public virtual ICollection<Disciplina> Disciplinas { get; set; }
  }
}