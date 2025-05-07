using EIMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.BLL.Repositories
{
    public interface IExamMarksRepository
    {
        Task<IEnumerable<ExamMark>> GetAllAsync();
        Task<ExamMark> GetByIdAsync(int id);
        Task AddAsync(ExamMark examMark);
        Task UpdateAsync(ExamMark examMark);
        Task DeleteAsync(int id);
    }
}
