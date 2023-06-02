using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaProcessos.Models;

namespace SistemaProcessos.Data.Map
{
    public class PessoasMap : IEntityTypeConfiguration<PessoasModel>
    {
        public void Configure(EntityTypeBuilder<PessoasModel> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(128);

            builder.Property(x => x.Cliente).IsRequired();

            builder.Property(x => x.Cpf_cnpj).HasMaxLength(20);

            builder.Property(x => x.Endereco).HasMaxLength(128);

            builder.Property(x => x.Email).HasMaxLength(128);

            builder.HasMany<ProcessosModel>()
            .WithOne()
            .HasForeignKey(x => x.Advogado_id);

        }
    }
}
