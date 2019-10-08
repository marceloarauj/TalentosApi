using api.Models.EntityModel.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.EntityModel.Users
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Cabecalhos");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(c => c.Name).HasColumnName("Nome");
            builder.Property(c => c.Graduation).HasColumnName("Graduacao");
            builder.Property(c => c.Email).HasColumnName("Email");
            builder.Property(c => c.Title).HasColumnName("Titulo");
            builder.Property(c => c.CarrearTime).HasColumnName("CarrearTime");
            builder.Property(c => c.Expertise).HasColumnName("Expertise");
            builder.Property(c => c.Dimention).HasColumnName("Dimention");
        }
    }
}