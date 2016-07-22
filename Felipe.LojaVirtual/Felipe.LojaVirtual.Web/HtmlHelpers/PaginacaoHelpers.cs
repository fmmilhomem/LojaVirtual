using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Felipe.LojaVirtual.Web.Models;

/// <summary>
/// Namespace contém as minhas classes
/// O Namespace pode conter 1 ou várias classes
/// Para que as classes de um namescape possam "enxergar" outras classes de namespace distintos é necessario utilizar using ou adicionar referencias;
/// </summary>
namespace Felipe.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaUrl)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i <= paginacao.TotalPagina; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == paginacao.PaginaAtual)
                {
                    tag.AddCssClass("Selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                resultado.Append(tag);

            }
            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}