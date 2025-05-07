using EIMS.DAL.Models;
using EIMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EIMS.BLL.Repositories
{
    public class ExamMarksRepository : IExamMarksRepository
    {
        private readonly EIMSDbContext _context;

        public ExamMarksRepository(EIMSDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ExamMark>> GetAllAsync()
        {
            return await _context.ExamMarks
                .Include(em => em.Student)
                .Include(em => em.Course)
            .ToListAsync();
        }

        public async Task<ExamMark> GetByIdAsync(int id)
        {
            return await _context.ExamMarks
                .Include(em => em.Student)
                .Include(em => em.Course)
                .FirstOrDefaultAsync(em => em.Id == id)??new ExamMark();
        }

        public async Task AddAsync(ExamMark examMarks)
        {
            _context.ExamMarks.Add(examMarks);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ExamMark examMarks)
        {
            _context.ExamMarks.Update(examMarks);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var examMarks = await _context.ExamMarks.FindAsync(id);
            if (examMarks != null)
            {
                _context.ExamMarks.Remove(examMarks);
                await _context.SaveChangesAsync();
            }
        }
    }
}
