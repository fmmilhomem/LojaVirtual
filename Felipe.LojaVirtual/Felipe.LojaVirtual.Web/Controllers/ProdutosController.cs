using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Felipe.LojaVirtual.Domino.Repositorio;

namespace Felipe.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produto


        private ProdutosRepositorio _repositorio;
        public ActionResult Index()
        {

            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.Take(10);

            return View(produtos);
        }
    }
}