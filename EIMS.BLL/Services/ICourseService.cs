using EIMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.BLL.Services
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>>GetAllCourseAsync();
        Task<Course>GetCourseByIdAsync(int id);
        Task AddCourseAsync(Course course);
        Task UpdateCourseAsync(Course course);
        Task DeleteCourseAsync(int id);
        Task<bool> IsCourseNameExists(string courseName);

    }

    //public class abc : ICourseService
    //{

    //}
} 
