using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  class Curso
  {
    public int CursoId { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string Nome { get; set; }

    public int QntPeriodos { get; set; }
    
    [Column(TypeName = "decimal(23,4)")]
    public decimal Valor { get; set; }

    public int CoordenadorId { get; set; }
    [ForeignKey("CoordenadorId")]
    public Coordenador Coordenador { get; set; }

    public virtual ICollection<Aluno> Alunos { get; set; }

    public virtual ICollection<CursoDisciplina> CursoDisciplinas { get; set; }
  }
}