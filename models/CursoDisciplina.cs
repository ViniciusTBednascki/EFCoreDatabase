using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  class CursoDisciplina
  {
    public int CursoId { get; set; }
    [ForeignKey("CursoId")]
    public Curso Curso { get; set; }

    public int DisciplinaId { get; set; }
    [ForeignKey("DisciplinaId")]
    public Disciplina Disciplina { get; set; }

    public int Periodo { get; set; }
  }
}