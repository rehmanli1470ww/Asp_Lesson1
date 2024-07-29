using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Servicies;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: StudentController
        public async Task<IActionResult> Index(string key="")
        {
            var result=await _studentService.GetAllByKeyAsync(key);
            return Ok(result);
        }
        public async Task<IActionResult> Add()
        {
            var vm = new Student() { };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Student student)
        {
            await _studentService.AddAsync(student);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>GetById(int id)
        {
           var result=await _studentService.GetByIdAsync(id);
            return Ok(result);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            await _studentService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
