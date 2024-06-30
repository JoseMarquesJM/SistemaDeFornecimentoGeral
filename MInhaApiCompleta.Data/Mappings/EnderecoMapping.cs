using FornecimentoGeral.Business.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace FornecimentoGeral.Data.Mappings;

public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(c => c.Logradouro)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(c => c.Numero)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(c => c.Cep)
            .IsRequired()
            .HasMaxLength(8);

        builder.Property(c => c.Complemento)
            .HasMaxLength(250);

        builder.Property(c => c.Bairro)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Cidade)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Estado)
            .IsRequired()
            .HasMaxLength(50);

        builder.ToTable("Enderecos");
    }
}
