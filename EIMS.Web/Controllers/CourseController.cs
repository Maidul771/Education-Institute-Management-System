using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using EIMS.BLL.Services;
using EIMS.DAL.Models;
namespace EIMS.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        // ✅ GET: /Course
        public async Task<IActionResult> Index()
        {
            var course = await _courseService.GetAllCourseAsync();
            return View(course);
        }

        // ✅ GET: /Course/Create
        public async Task<IActionResult> Create()
        {
           
            return View();
        }
        // ✅ POST: /Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course)
        {
            if (ModelState.IsValid)
            {
                if (await _courseService.IsCourseNameExists(course.CourseName))
                {
                    //return View(course);
                    ModelState.AddModelError("CourseName", "Course name already exists.");
                    return View(course);

                }
                await _courseService.AddCourseAsync(course);
                return RedirectToAction(nameof(Index));
            }

            return View(course);
        }
        // ✅ GET: /Course/Edit/{id}
        public async Task<IActionResult> Edit(int id)
        {
            var course = await _courseService.GetCourseByIdAsync(id);
            if (course == null)
                return NotFound();

            return View(course);
        }
        // ✅ POST: /ExamMarks/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Course course)
        {
            if (id != course.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                if (await _courseService.IsCourseNameExists(course.CourseName))
                {
                    //return View(course);
                    ModelState.AddModelError("CourseName", "Course name already exists.");
                    return View(course);

                }
                await _courseService.UpdateCourseAsync(course);
                return RedirectToAction(nameof(Index));
            }

            return View(course);
        }
        // ✅ GET: /ExamMarks/Delete/{id}
        public async Task<IActionResult> Delete(int id)
        {
            var course = await _courseService.GetCourseByIdAsync(id);
            if (course == null)
                return NotFound();

            return View(course);
        }
        // ✅ POST: /ExamMarks/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _courseService.DeleteCourseAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
