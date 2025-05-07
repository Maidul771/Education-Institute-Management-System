using EIMS.BLL.Services;
using EIMS.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EIMS.Web.Controllers
{
    public class ExamMarksController : Controller
    {
        private readonly IExamMarksService _examMarksService;

        public ExamMarksController(IExamMarksService examMarksService)
        {
            _examMarksService = examMarksService;
        }

        // ✅ GET: /ExamMarks
        public async Task<IActionResult> Index()
        {
            var examMarks = await _examMarksService.GetAllExamMarksAsync();
            return View(examMarks);
        }

        // ✅ GET: /ExamMarks/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Students = (await _examMarksService.GetAllStudentsAsync())
                                .Select(s => new { s.Id, s.Name });

            ViewBag.Courses = (await _examMarksService.GetAllCoursesAsync())
                                .Select(c => new { c.Id, c.CourseName });

            //// Fetching students from the service
            //var students = await _examMarksService.GetAllStudentsAsync();

            //// Check if the list is null and initialize as empty if needed
            //ViewBag.Students = new SelectList(students ?? new List<Student>(), "Id", "Name");

            //var courses = await _examMarksService.GetAllCoursesAsync();
            //// Check if the courses list is null
            //ViewBag.Courses = new SelectList(courses ?? new List<Course>(), "Id", "CourseName");

            return View();
        }

        // ✅ POST: /ExamMarks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ExamMark examMarks)
        {
            if (ModelState.IsValid)
            {
                await _examMarksService.AddExamMarksAsync(examMarks);
                return RedirectToAction(nameof(Index));
            }

            return View(examMarks);
        }

        // ✅ GET: /ExamMarks/Edit/{id}
        public async Task<IActionResult> Edit(int id)
        {
            var examMark = await _examMarksService.GetExamMarksByIdAsync(id);
            if (examMark == null)
                return NotFound();

            ViewBag.Students = (await _examMarksService.GetAllStudentsAsync()).Select(s => new { s.Id, s.Name });
            ViewBag.Courses = (await _examMarksService.GetAllCoursesAsync()).Select(c => new { c.Id, c.CourseName });

            return View(examMark);
        }

        // ✅ POST: /ExamMarks/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ExamMark examMark)
        {
            if (id != examMark.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                await _examMarksService.UpdateExamMarksAsync(examMark);
                return RedirectToAction(nameof(Index));
            }

            return View(examMark);
        }

        // ✅ GET: /ExamMarks/Delete/{id}
        public async Task<IActionResult> Delete(int id)
        {
            var examMark = await _examMarksService.GetExamMarksByIdAsync(id);
            if (examMark == null)
                return NotFound();

            return View(examMark);
        }

        // ✅ POST: /ExamMarks/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _examMarksService.DeleteExamMarksAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
