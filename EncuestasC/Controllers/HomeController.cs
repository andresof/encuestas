using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EncuestasC.Models;

namespace EncuestasC.Controllers
{
    public class HomeController : Controller
    {
        private EncuestasEntitiesx _entities = new EncuestasEntitiesx();


        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult DCanton()
        {
            return View(_entities.Canton.ToList());

        }

        public ActionResult DCodPres()
        {
            return View(_entities.CodigoPresupuestario.ToList());

        }

        public ActionResult DCPSP()
        {
            return View(_entities.CPSP.ToList());

        }

        public ActionResult DDistrito()
        {
            return View(_entities.Distrito.ToList());

        }

        public ActionResult DEmail()
        {
            return View(_entities.Email.ToList());

        }

        public ActionResult DEncuesta()
        {
            return View(_entities.Encuesta.ToList());

        }

        public ActionResult DEstSer()
        {
            return View(_entities.EstadoServicio.ToList());

        }

        public ActionResult DPoblado()
        {
            return View(_entities.Poblado.ToList());

        }

        public ActionResult DProvincia()
        {
            return View(_entities.Provincia.ToList());

        }

        public ActionResult DProyecto()
        {
            return View(_entities.Proyecto.ToList());

        }

        public ActionResult DTelefono()
        {
            return View(_entities.Telefono.ToList());

        }

       

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(CodigoPresupuestariox codigoPresupuestarioToCreate)
        {
            try
            {
                // TODO: Add insert logic here
                _entities.AddToCodigoPresupuestario(codigoPresupuestarioToCreate);
                _entities.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Home/Edit/5
 
        public ActionResult Edit(int Id)
        {
            var CodigoPresupuestarioToEdit = (from m in _entities.CodigoPresupuestario
                               where m.Id == Id
                               select m).First();
            return View(CodigoPresupuestarioToEdit);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(CodigoPresupuestariox codigoPresupuestarioToEdit)
        {
         
                // TODO: Add update logic here
                var originalCodigoPresupuestario = (from m in _entities.CodigoPresupuestario
                                                     where m.Id == codigoPresupuestarioToEdit.Id
                                                     select m).First();



                if (!ModelState.IsValid)

                    return View(originalCodigoPresupuestario);

                _entities.ApplyPropertyChanges(originalCodigoPresupuestario.EntityKey.EntitySetName, codigoPresupuestarioToEdit);

                _entities.SaveChanges(); 

                return RedirectToAction("Index");
            
            
        }

        //
        // GET: /Home/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
