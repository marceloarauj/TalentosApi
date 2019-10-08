using api.Models.EntityModel.Searches;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.EntityModel.Searches
{
    public class SearchMap : IEntityTypeConfiguration<Search>
    {
        public void Configure(EntityTypeBuilder<Search> builder)
        {
            builder.ToTable("Pesquisas");
            builder.HasKey(p => new {p.UserId, p.SportId});
            builder.Property(p => p.UserId).HasColumnName("IdUsuario");
            builder.Property(p => p.SportId).HasColumnName("IdEsporte");
            builder.Property(p => p.Force).HasColumnName("Forca");
            builder.Property(p => p.Speed).HasColumnName("Velocidade");
            builder.Property(p => p.MotorCoordination).HasColumnName("Coordenacao");
            builder.Property(p => p.Power).HasColumnName("Potencia");
            builder.Property(p => p.Agility).HasColumnName("Agilidade");
            builder.Property(p => p.Hypertrophy).HasColumnName("Hipertrofia");
            builder.Property(p => p.Resistance).HasColumnName("Resistencia");
            builder.Property(p => p.BodyHeight).HasColumnName("Estatura");
            builder.Property(p => p.Height).HasColumnName("Altura");
            builder.Property(p => p.Wingspan).HasColumnName("Envergadura");
            builder.HasOne(p => p.User).WithMany(c => c.Searches).HasForeignKey(p => p.UserId);
            builder.HasOne(p => p.Sport).WithMany(c => c.Searches).HasForeignKey(p => p.SportId);
        }
    }
}