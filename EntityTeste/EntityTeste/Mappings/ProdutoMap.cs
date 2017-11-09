using EntityTeste.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EntityTeste.Mappings
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("Produto");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Titulo)
                .IsRequired()
                .HasMaxLength(60);

            HasRequired(x => x.Categoria)
                .WithMany(x => x.Produtos);
        }
    }
}
