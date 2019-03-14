using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculadora.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //inicializa o inicial do visor
            ViewBag.Ecra = "0";

            //variavel axiliar
            Session["primeiraVezOperador"] = true;

            return View();
        }  
        // GET: Post
        [HttpPost]
        public ActionResult Index(string bt,string visor){
            //var.auxiliar
            string ecra = visor;

            //identificar o valor na variável 'bt'
            switch (bt)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    // se entrei aqui é porque foi selecionado o 'algorismo'
                    // vou decidir o que fazer quando no visor so existe o 'zero'
                    if(visor == "0") // ou visor.Equals("0")
                    {
                        ecra = bt;
                    }
                    else
                    {
                        ecra = ecra + bt; 
                    }
                break;
                case ",":
                    // processar o caso da ','
                    if (!visor.Contains(","))
                    {
                        ecra = ecra + bt;
                    }
                    break;

                // se entrei aqui e porque foi selecionado um 'operador'
                case "+":
                case "-":
                case "x":
                case ":":
                    //é a 1ª vez que carreguei destes operadores
                    if ((bool)Session["primeiraVezOperador"] == true) { }
                    break;
            }

            // prepara o conteudo a aparecer no visor da view
            ViewBag.Ecra = ecra;
            return View();
        }
    }
}