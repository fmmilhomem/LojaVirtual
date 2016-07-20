using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Felipe.LojaVirtual.Domino.Entidades;

namespace Felipe.LojaVirtual.Domino.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EntityFrameworkDBContext _context = new EntityFrameworkDBContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }


        }
    }
}
