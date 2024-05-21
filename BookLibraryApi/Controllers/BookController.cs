using BookLibraryDTO.Model;
using BookLibraryDTO.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace BookLibraryApi.Controllers
{
    [ApiController]
    [Route("WebAPI/[controller]")]
    public class BookController : Controller
    {
        private readonly BookService _BookService;

        public BookController(BookService BookService)
        {
            _BookService = BookService;
        }
        [HttpPost]
        [Route("CreateBook")]
        public Task<ResponseModel> CreateBook(BookEntity bookEntity)
        {
            ResponseModel response = new ResponseModel();
            response = _BookService.Create(bookEntity);

            return Task.FromResult(response);
        }
        [HttpPost]
        [Route("ListBook")]
        public Task<ResponseModel> Listbook()
        {
            ResponseModel response = new ResponseModel();
            response = _BookService.list();
            Log.Information("BookLog => {@response} ", response);

            return Task.FromResult(response);
        }

        [HttpPost]
        [Route("UpdateBook")]
        public Task<ResponseModel> UpdateBook(BookEntity bookEntity)
        {
            ResponseModel response = new ResponseModel();
            response = _BookService.Update(bookEntity);

            return Task.FromResult(response);
        }
        [HttpPost]
        [Route("DeleteBook/{id}")]
        public Task<ResponseModel> DeleteBook(int id)
        {
            ResponseModel response = new ResponseModel();
            response = _BookService.Delete(id);

            return Task.FromResult(response);
        }
        [HttpPost]
        [Route("GetByBookId/{id}")]
        public Task<ResponseModel> GetByBookId(int id)
        {
            ResponseModel response = new ResponseModel();
            response = _BookService.GetById(id);

            return Task.FromResult(response);
        }

    }
}
