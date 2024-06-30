using FornecimentoGeral.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FornecimentoGeral.Data.Mappings;

public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
{
    public void Configure(EntityTypeBuilder<Fornecedor> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.Documento)
            .IsRequired()
            .HasMaxLength(14);

        // 1 : 1 => Fornecedor : Endereco
        builder.HasOne(f => f.Endereco)
            .WithOne(e => e.Fornecedor);

        // 1 : N => Fornecedor : Produtos
        builder.HasMany(f => f.Produtos)
            .WithOne(p => p.Fornecedor)
            .HasForeignKey(p => p.FornecedorId);

        builder.ToTable("Fornecedores");
    }
}
