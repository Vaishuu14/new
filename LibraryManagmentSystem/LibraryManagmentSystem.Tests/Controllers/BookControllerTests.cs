using AutoMapper;
using LibraryManagmentSystem.Application.Commands.BookCommands;
using LibraryManagmentSystem.Application.DTOs;
using LibraryManagmentSystem.Application.Queries.BookQueries;
using LibraryManagmentSystem.Domain.Entities;
using LibraryManagmentSystem.Domain.Interfaces;
using LibraryManagmentSystem.Web.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace LibraryManagmentSystem.Tests.Controllers
{
    public class BookControllerTests
    {
        private readonly Mock<IMediator> _mediatorMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<IBookRepository> _bookServiceMock;
        private readonly BookController _controller;
       


        public BookControllerTests()
        {
            _mediatorMock = new Mock<IMediator>();
            _mapperMock = new Mock<IMapper>();
            _bookServiceMock = new Mock<IBookRepository>();
            _controller = new BookController(_mediatorMock.Object, _mapperMock.Object, _bookServiceMock.Object);

        }

        [Fact]
        public async Task Index_ReturnsPartialView_WithBooks()
        {
            // Arrange
            var books = new List<BookDto> { new BookDto { Id = 1, Title = "Test Book" } };
            _mediatorMock.Setup(m => m.Send(It.IsAny<GetBooksQuery>(), default)).ReturnsAsync(books);

            // Act
            var result = await _controller.Index();

            // Assert
            var viewResult = Assert.IsType<PartialViewResult>(result);
            Assert.Equal("Index", viewResult.ViewName);
            Assert.Equal(books, viewResult.Model);
        }

        [Fact]
        public void Create_ReturnsView()
        {
            // Act
            var result = _controller.Create();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.Model);
        }


       


        [Fact]
        public async Task Create_Post_InvalidModel_ReturnsView()
        {
            // Arrange
            var command = new CreateBookCommand();
            _controller.ModelState.AddModelError("Title", "Required");

            // Act
            var result = await _controller.Create(command);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(command, viewResult.Model);
        }

        //[Fact]
        //public async Task Edit_Get_ExistingBook_ReturnsViewWithUpdateBookCommand()
        //{
        //    // Arrange
        //    var bookDto = new BookDto { Id = 1, Title = "Test Book" }; // DTO
        //    var updateBookCommand = new UpdateBookCommand { Id = 1, Title = "Test Book" }; // Command

        //    // Setup mock to return the book DTO
        //    _bookServiceMock.Setup(m => m.GetByIdAsync(1)).ReturnsAsync(bookDto);
        //    _mapperMock.Setup(m => m.Map<UpdateBookCommand>(bookDto)).Returns(updateBookCommand);

        //    // Act
        //    var result = await _controller.Edit(1);

        //    // Assert
        //    var viewResult = Assert.IsType<ViewResult>(result);
        //    var model = Assert.IsAssignableFrom<UpdateBookCommand>(viewResult.Model);
        //    Assert.Equal(updateBookCommand.Title, model.Title);
        //}

        //[Fact]
        //public async Task Edit_Post_ValidModel_RedirectsToIndex()
        //{
        //    // Arrange
        //    var command = new UpdateBookCommand { Id = 1, Title = "Updated Book" };
        //    _mediatorMock.Setup(m => m.Send(command, default)).ReturnsAsync(true);

        //    // Act
        //    var result = await _controller.Edit(command);

        //    // Assert
        //    var redirectResult = Assert.IsType<RedirectToActionResult>(result);
        //    Assert.Equal("Index", redirectResult.ActionName);
        //}

        [Fact]
        public async Task Edit_Post_InvalidModel_ReturnsView()
        {
            // Arrange
            var command = new UpdateBookCommand { Id = 1, Title = "Invalid Book" };
            _controller.ModelState.AddModelError("Title", "The Title field is required."); // Simulate invalid model state

            // Act
            var result = await _controller.Edit(command);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<UpdateBookCommand>(viewResult.Model);
            Assert.Equal(command.Title, model.Title);
        }






    }
}
