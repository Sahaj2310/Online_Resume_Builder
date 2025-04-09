using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Data;
using ResumeBuilder.Models;
using System.Linq;

namespace ResumeBuilder.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ResumeContext _context;

        public ResumeController(ResumeContext context)
        {
            _context = context;
        }

        //linq query used 
        public IActionResult Index()
        {
            var resumes = _context.Resumes.ToList();
            return View(resumes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Resume resume)
        {
            if (ModelState.IsValid)
            {
                _context.Resumes.Add(resume);
                _context.SaveChanges();
                return RedirectToAction("ViewResume", new { id = resume.Id });
            }
            return View(resume);
        }

        public IActionResult ViewResume(int? id)
        {
            if (id == null)
                return NotFound();

            var resume = _context.Resumes.FirstOrDefault(r => r.Id == id);
            if (resume == null)
                return NotFound();

            return View(resume);
        }

        public IActionResult PrintResume(int? id)
        {
            if (id == null)
                return NotFound();

            var resume = _context.Resumes.FirstOrDefault(r => r.Id == id);
            if (resume == null)
                return NotFound();

            return View(resume);
        }

        // Resume and Delete code
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var resume = _context.Resumes.FirstOrDefault(r => r.Id == id);
            if (resume == null)
                return NotFound();

            return View(resume);
        }

        // Resume and Delete code 
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var resume = _context.Resumes.FirstOrDefault(r => r.Id == id);
            if (resume == null)
                return NotFound();

            _context.Resumes.Remove(resume);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
