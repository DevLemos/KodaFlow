using KodeFlow.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KodeFlow.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Tutor> Tutores { get; set; }
    public DbSet<Contato> Contatos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Animal> Animais { get; set; }
    public DbSet<Raca> Racas { get; set; }
    public DbSet<Especie> Especies { get; set; }
    public DbSet<Consulta> Consultas { get; set; }
    public DbSet<Prontuario> Prontuarios { get; set; }
    public DbSet<Veterinario> Veterinarios { get; set; }
    public DbSet<Especialidade> Especialidades { get; set; }
}
