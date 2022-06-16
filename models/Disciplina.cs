using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  class Disciplina
  {
    public int DisciplinaId { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string Nome { get; set; }

    public int CargaHoraria { get; set; }

    public int ProfessorId { get; set; }
    [ForeignKey("ProfessorId")]
    public Professor Professor { get; set; }

    public virtual ICollection<CursoDisciplina> CursoDisciplinas { get; set; }
  }
}