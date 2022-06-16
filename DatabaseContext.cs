using Microsoft.EntityFrameworkCore;
using Models;

namespace Database {
  class DataBaseContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=LAPTOP-RNUAFD99;Database=Atividade;Trusted_Connection=True",
        options => options.EnableRetryOnFailure());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<CursoDisciplina>().HasKey(cd => new { cd.CursoId, cd.DisciplinaId, cd.Periodo });
    }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<Coordenador> Coordenadores { get; set; }
    public DbSet<Diretor> Diretores { get; set; }
    public DbSet<Disciplina> Disciplinas { get; set; }
    public DbSet<Curso> Cursos { get; set; }
  }
}