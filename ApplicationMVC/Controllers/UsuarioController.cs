using App.Domain.Mapper;
using App.Domain.Models;
using App.Infra.Data.Context;
using App.Service.Services;
using ApplicationMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationMVC.Controllers
{
    public class UsuarioController : BaseWebController
    {
        private readonly UsuarioService service;
        public UsuarioController(ApiContext context) : base(context)
        {
            service = new UsuarioService(context);
        }

        public IActionResult Index()
        {
            var usrs = service.Get().Select(x=>x.ToModel()).ToList();
            return View(usrs);

        }

        public IActionResult Edit(Guid id)
        {
            var usr = service.Get(id);
            return View(usr.ToEditModel());
        }

        [HttpPost]
        public IActionResult Edit(UsuarioEditModel model)
        {
            var usr = service.Put(model.ToEntity());
            if (usr != null)
                return RedirectToAction("Index");
            else
                return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UsuarioCreateModel model)
        {
            service.Post(model.ToEntity());
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            return View(service.Get(id).ToModel());
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(Guid id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }


    }
}
