using EIMS.BLL.Services;
using EIMS.DAL.Models;
using EIMS.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.UnitTest
{
    [TestClass]
    public class ExamMarksControllerTests
    {
        private Mock<IExamMarksService> _mockExamMarksService;
        private ExamMarksController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockExamMarksService = new Mock<IExamMarksService>();
            _controller = new ExamMarksController(_mockExamMarksService.Object);
        }

        [TestMethod]
        public async Task Index_ReturnsViewWithExamMarks()
        {
            // Arrange
            var examMarksList = new List<ExamMark>
            {
                new ExamMark { Id = 1, StudentId = 1, CourseId = 1, MCQ = 80, Written = 70 },
                new ExamMark { Id = 2, StudentId = 2, CourseId = 2, MCQ = 85, Written = 75 }
            };
            _mockExamMarksService.Setup(service => service.GetAllExamMarksAsync()).ReturnsAsync(examMarksList);

            // Act
            var result = await _controller.Index();

            // Assert
            //var viewResult = Assert.IsInstanceOfType(result, typeof(ViewResult));
            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult)); // Ensure it returns a List
            var model = (IEnumerable<ExamMark>)((ViewResult)result).Model;
            Assert.AreEqual(2, model.Count());
        }

        [TestMethod]
        public async Task Create_Post_ReturnsRedirectToAction()
        {
            // Arrange
            var examMarks = new ExamMark { Id = 1, StudentId = 1, CourseId = 1, MCQ = 80, Written = 70 };
            _mockExamMarksService.Setup(service => service.AddExamMarksAsync(It.IsAny<ExamMark>())).Returns(Task.CompletedTask);

            // Act
            var result = await _controller.Create(examMarks);

            // Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
            Assert.AreEqual("Index", ((RedirectToActionResult)result).ActionName);
        }

        [TestMethod]
        public async Task Edit_Get_ReturnsViewWithExamMarks()
        {
            // Arrange
            var examMarks = new ExamMark { Id = 1, StudentId = 1, CourseId = 1, MCQ = 80, Written = 70 };
            _mockExamMarksService.Setup(service => service.GetExamMarksByIdAsync(1)).ReturnsAsync(examMarks);

            // Act
            var result = await _controller.Edit(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var model = (ExamMark)((ViewResult)result).Model;
            Assert.AreEqual(1, model.Id);
        }
    }
}
