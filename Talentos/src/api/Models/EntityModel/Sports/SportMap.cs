using api.Models.EntityModel.Sports;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.EntityModel.Sports
{
    public class SportMap : IEntityTypeConfiguration<Sport>
    {
        public void Configure(EntityTypeBuilder<Sport> builder)
        {
            builder.ToTable("Esportes");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(s => s.Name).HasColumnName("Nome");
        }
    }
}