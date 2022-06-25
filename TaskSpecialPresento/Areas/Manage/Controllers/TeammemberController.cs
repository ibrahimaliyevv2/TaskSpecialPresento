using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskSpecialPresento.DAL;
using TaskSpecialPresento.Models;

namespace TaskSpecialPresento.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class TeammemberController : Controller
    {
        private readonly AppDbContext _context;

        public TeammemberController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var data = _context.Teammembers.ToList();

            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Teammember teammember)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if(teammember == null)
            {
                return RedirectToAction("error", "dashboard");
            }

            _context.Teammembers.Add(teammember);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Teammember teammember = _context.Teammembers.FirstOrDefault(x => x.Id == id);

            if(teammember == null)
            {
                return RedirectToAction("error", "dashboard");
            }

            return View(teammember);
        }

        [HttpPost]
        public IActionResult Edit(Teammember teammember)
        {

        }
    }
}
