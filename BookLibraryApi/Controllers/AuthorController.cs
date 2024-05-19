using BookLibraryDTO.Model;
using BookLibraryDTO.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [ApiController]
    [Route("WebAPI/[controller]")]
    public class AuthorController : Controller
    {
        private readonly AuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }
        [HttpPost]
        [Route("CreateAuthor")]
        public Task <ResponseModel> CreateAuthor(AuthorEntity authorEntity) { 
        ResponseModel response= new ResponseModel();
            response = _authorService.Create(authorEntity);
        
            return Task.FromResult(response);
        }
        [HttpPost]
        [Route("ListAuthor")]
        public Task<ResponseModel> ListAuthor()
        {
            ResponseModel response = new ResponseModel();
            response = _authorService.list();

            return Task.FromResult(response);
        }
        [HttpPost]
        [Route("UpdateAuthor")]
        public Task<ResponseModel> UpdateAuthor(AuthorEntity authorEntity)
        {
            ResponseModel response = new ResponseModel();
            response = _authorService.Update(authorEntity);

            return Task.FromResult(response);
        }
        [HttpPost]
        [Route("DeleteAuthor")]
        public Task<ResponseModel> DeleteAuthor(int id)
        {
            ResponseModel response = new ResponseModel();
            response = _authorService.Delete(id);

            return Task.FromResult(response);
        }
        [HttpPost]
        [Route("GetByAuthorId")]
        public Task<ResponseModel> GetByAuthorId(int id)
        {
            ResponseModel response = new ResponseModel();
            response = _authorService.GetById(id);

            return Task.FromResult(response);
        }

    }
}
