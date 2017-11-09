using EntityTeste.Domain;
using System;
using System.Data.Entity;
using System.Linq;

namespace EntityTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataContext.DataContext())
            {

                //foreach (var produto in db.Produtos)
                //{
                //    Console.WriteLine(produto.Titulo);
                //}

                #region CREATE
                //db.Produtos.Add(new Produto
                //{
                //    Titulo = "Titulo s",
                //    CategoriaId = new Guid("FBE55FBF-45C5-E711-B67F-90CDB6A2687A")
                //});
                #endregion

                #region UPDATE
                //var produto = db.Produtos.Where(x => x.Id == new Guid("FCE55FBF-45C5-E711-B67F-90CDB6A2687A")).FirstOrDefault();

                //produto.Titulo = "Alteração 1";

                //db.Entry<Produto>(produto).State = EntityState.Modified;

                //db.SaveChanges();
                #endregion

                #region DELETE

                //db.Categorias.Remove(db.Categorias.First());
                //db.SaveChanges();
                #endregion

                #region LISTAS
                var result = db.Produtos.Where(x => x.Titulo == "Titulo 1");
                result.Where(x => x.CategoriaId == new Guid("1FC2B2DA-4BC5-E711-B67F-90CDB6A2687A"));

                result.Select(x => new
                {

                    Titulo = x.Titulo
                });

                foreach (var item in result.ToList())
                {
                    Console.WriteLine(item.Titulo);
                }
                #endregion

                Console.WriteLine("=====================================");

                foreach (var categoria in db.Categorias
                    .Include(x => x.Produtos) //LAZY LOADING -> SÓ UTILIZADO QUANDO ACESSADO categoria.Produtos
                    .OrderBy(x => x.Descricao))
                {
                    Console.WriteLine(categoria.Descricao);

                    foreach (var produto in categoria.Produtos)
                    {
                        Console.WriteLine("\t" + produto.Titulo);
                    }

                }

            }


            //Enable-Migrations
            //Add-Migration 'AdicionadoCampoNomeNoProduto'
            //Update-Database
            //Update-Database -script -force -verbose

            Console.ReadKey();
        }
    }
}
