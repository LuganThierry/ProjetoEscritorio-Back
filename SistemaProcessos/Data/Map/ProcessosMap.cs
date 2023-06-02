using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaProcessos.Models;

namespace SistemaProcessos.Data.Map
{
    public class ProcessosMap : IEntityTypeConfiguration<ProcessosModel>
    {
        public void Configure(EntityTypeBuilder<ProcessosModel> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Advogado_id).IsRequired();

            builder.Property(x => x.Cliente_id).IsRequired();

            builder.Property(x => x.Numero_processo).IsRequired().HasMaxLength(35);

            builder.Property(x => x.Proximo_prazo).IsRequired();

            builder.Property(x => x.Arquivo).IsRequired();

            builder.HasOne<PessoasModel>()
            .WithMany()
            .HasForeignKey(x => x.Advogado_id);
        }
    }
}
