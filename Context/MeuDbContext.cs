using DefaultAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;

public class MeuDbContext : DbContext
{
    public MeuDbContext(DbContextOptions<MeuDbContext> options)
        : base(options)
    { }

    public DbSet<UnidadesMedidaDistancia> UnidadesMedidaDistancia { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UnidadesMedidaDistancia>(entity =>
        {
            entity.ToTable("lstUnidadesMedidaDistancia");
            entity.HasKey(e => e.ID); // primary key
            entity.Property(e => e.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            entity.Property(e => e.Sigla).HasColumnName("Sigla").IsRequired();
            entity.Property(e => e.Nome).HasColumnName("Nome").IsRequired();
        });
    }
}