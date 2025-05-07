using EIMS.BLL.Repositories;
using EIMS.BLL.Services;
using EIMS.DAL.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.UnitTest
{
    [TestClass]
    public class ExamMarksServiceTests
    {
        private Mock<IExamMarksRepository> _mockExamMarksRepo;
        private Mock<IStudentRepository> _mockStudentRepo;
        private Mock<ICourseRepository> _mockCourseRepo;
        private ExamMarksService _examMarksService;

        //[TestInitialize]
        //public void Setup()
        //{
        //    _mockExamMarksRepo = new Mock<IExamMarksRepository>();
        //    _mockStudentRepo = new Mock<IStudentRepository>();
        //    _mockCourseRepo = new Mock<ICourseRepository>();
        //    _examMarksService = new ExamMarksService(_mockExamMarksRepo.Object, _mockStudentRepo.Object, _mockCourseRepo.Object);
        //}
        [TestInitialize]
        public void Setup()
        {
            _mockExamMarksRepo = new Mock<IExamMarksRepository>();
            _mockStudentRepo = new Mock<IStudentRepository>();
            _mockCourseRepo = new Mock<ICourseRepository>();

            // Setup default behavior to avoid null exceptions
            _mockExamMarksRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(new List<ExamMark>());
            _mockStudentRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(new List<Student>());
            _mockCourseRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(new List<Course>());

            _examMarksService = new ExamMarksService(_mockExamMarksRepo.Object, _mockStudentRepo.Object, _mockCourseRepo.Object);
        }
        [TestMethod]
        public async Task AddExamMarksAsync_ValidExamMarks_ShouldAdd()
        {
            // Arrange
            var examMarks = new ExamMark { Id = 1, StudentId = 1, CourseId = 1, MCQ = 80, Written = 70 };
            _mockExamMarksRepo.Setup(repo => repo.AddAsync(It.IsAny<ExamMark>())).Returns(Task.CompletedTask);

            // Act
            await _examMarksService.AddExamMarksAsync(examMarks);

            // Assert
            _mockExamMarksRepo.Verify(repo => repo.AddAsync(It.IsAny<ExamMark>()), Times.Once);
        }

        [TestMethod]
        public async Task GetExamMarksByIdAsync_ValidId_ShouldReturnExamMarks()
        {
            // Arrange
            var examMarks = new ExamMark { Id = 50, StudentId = 88, CourseId = 77, MCQ = 80, Written = 70 };
            _mockExamMarksRepo.Setup(repo => repo.GetByIdAsync(50)).ReturnsAsync(examMarks);

            // Act
            var result = await _examMarksService.GetExamMarksByIdAsync(50);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(50, result.Id);
        }

        [TestMethod]
        public async Task DeleteExamMarksAsync_ValidId_ShouldDelete()
        {
            // Arrange
            var examMarks = new ExamMark { Id = 1, StudentId = 1, CourseId = 1, MCQ = 80, Written = 70 };
            _mockExamMarksRepo.Setup(repo => repo.DeleteAsync(1)).Returns(Task.CompletedTask);

            // Act
            await _examMarksService.DeleteExamMarksAsync(1);

            // Assert
            _mockExamMarksRepo.Verify(repo => repo.DeleteAsync(1), Times.Once);
        }

        [TestMethod]
        public async Task GetAllExamMarksAsync_ShouldReturnExamMarks()
        {
            // Arrange
            var examMarksList = new List<ExamMark>
            {
                new ExamMark { Id = 1, StudentId = 1, CourseId = 1, MCQ = 80, Written = 70 },
                new ExamMark { Id = 2, StudentId = 2, CourseId = 2, MCQ = 85, Written = 75 }
            };
            _mockExamMarksRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(examMarksList);

            // Act
            var result = await _examMarksService.GetAllExamMarksAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }
    }
}
