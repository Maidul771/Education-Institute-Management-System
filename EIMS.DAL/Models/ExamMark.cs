using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.DAL.Models
{
    public class ExamMark
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Range(0, 100, ErrorMessage = "MCQ marks must be between 0 and 100.")]
        public int MCQ { get; set; }

        [Range(0, 100, ErrorMessage = "Written marks must be between 0 and 100.")]
        public int Written { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student? Student { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course? Course { get; set; }
    }
}
