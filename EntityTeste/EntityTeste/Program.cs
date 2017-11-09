using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataContext.DataContext())
            {
                foreach (var produto in db.Produtos)
                {
                    Console.WriteLine(produto.Titulo);
                }
            }

            Console.ReadKey();
        }
    }
}
