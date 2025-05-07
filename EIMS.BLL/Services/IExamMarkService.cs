using EIMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.BLL.Services
{
    public interface IExamMarksService
    {
        Task<IEnumerable<ExamMark>> GetAllExamMarksAsync();
        Task<ExamMark> GetExamMarksByIdAsync(int id);
        Task AddExamMarksAsync(ExamMark examMarks);
        Task UpdateExamMarksAsync(ExamMark examMarks);
        Task DeleteExamMarksAsync(int id);

        // Additional methods for Students and Courses
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<IEnumerable<Course>> GetAllCoursesAsync();
    }
}
