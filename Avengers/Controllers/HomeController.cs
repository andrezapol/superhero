using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avengers.Entidade;
using Avengers.Aplicacao;

namespace Avengers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            string strName = string.Empty;
            string strDescription = string.Empty;
            Heroes oheroes = new Heroes();
            AvengersApp oAvengersApp = new AvengersApp();

            strName = form["txtName"];
            strDescription = form["txtDescription"];

            oheroes.HeroName = strName;
            oheroes.HeroDescription = strDescription;

            //Insere os dados no banco de dados
            if (oAvengersApp.Insert(oheroes) == true)
            {
                
            } else
            {

            }

            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            List<Heroes> lstheroes = new List<Heroes>();
            AvengersApp oAvengersApp = new AvengersApp();

            lstheroes = oAvengersApp.List();

            return PartialView(lstheroes);
        }
    }
}