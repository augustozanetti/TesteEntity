using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTeste.Domain
{
    public class Produto
    {
        public Guid Id { get; set; }

        public string Titulo { get; set; }

        public string Nome { get; set; }

        public Guid CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
