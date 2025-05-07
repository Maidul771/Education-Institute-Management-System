using EIMS.BLL.Repositories;
using EIMS.DAL;
using EIMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.BLL.Services
{
    public class ExamMarksService : IExamMarksService
    {
        private readonly IExamMarksRepository _examMarksRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;

        public ExamMarksService(IExamMarksRepository examMarksRepository, IStudentRepository studentRepository, ICourseRepository courseRepository)
        {
            _examMarksRepository = examMarksRepository;
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }

        public async Task<IEnumerable<ExamMark>> GetAllExamMarksAsync()
        {
            return await _examMarksRepository.GetAllAsync();
        }

        public async Task<ExamMark> GetExamMarksByIdAsync(int id)
        {
            return await _examMarksRepository.GetByIdAsync(id);
        }

        public async Task AddExamMarksAsync(ExamMark examMarks)
        {
            await _examMarksRepository.AddAsync(examMarks);
        }

        public async Task UpdateExamMarksAsync(ExamMark examMarks)
        {
            await _examMarksRepository.UpdateAsync(examMarks);
        }

        public async Task DeleteExamMarksAsync(int id)
        {
            await _examMarksRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _courseRepository.GetAllAsync();
        }
    }
}
