using EntityTeste.Domain;
using EntityTeste.Mappings;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EntityTeste.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("StringConnection")
        {
            //Database.SetInitializer<DataContext>(new Initializer());
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new CategoriaMap());

            base.OnModelCreating(modelBuilder);
        }
    }

    //public class Initializer : DropCreateDatabaseAlways<DataContext>
    //{
    //    protected override void Seed(DataContext context)
    //    {
    //        var categoria = new Categoria
    //        {
    //            Descricao = "Categoria 1"
    //        };

    //        context.Categorias.Add(categoria);

    //        context.Produtos.Add(new Produto
    //        {
    //            Titulo = "Titulo 1",
    //            CategoriaId = categoria.Id
    //        });

    //        context.SaveChanges();
            
    //    }
    //}
}
