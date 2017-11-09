using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTeste.Domain
{
    public class Categoria
    {
        public Categoria()
        {
            Produtos = new List<Produto>();
        }

        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
