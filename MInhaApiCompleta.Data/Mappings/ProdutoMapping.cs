using FornecimentoGeral.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FornecimentoGeral.Data.Mappings;

public class ProdutoMapping : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.Descricao)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(p => p.Imagem)
            .IsRequired()
            .HasMaxLength(100);

        builder.ToTable("Produtos");
    }
}
