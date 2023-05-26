using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Criar()
        {
            return View();
        }
        
        public ActionResult Editar()
        {
            return View();
        }
        
        public ActionResult Apagar()
        {
            return View();
        }

        public ActionResult ApagarConfirmacao()
        {
            return View();
        }
    }
}
