using BookLibraryDTO.Model;
using BookLibraryDTO.Services;
using Microsoft.AspNetCore.Mvc;
using Refit;
using Serilog;
using System.Text.Json.Serialization;


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
        [HttpGet]
        [Route("ListAuthor")]
        public Task<ResponseModel> ListAuthor()
        {
            Log.Information("Reached in the API");
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
        [Route("DeleteAuthor/{id}")]
        public Task<ResponseModel> DeleteAuthor(int id)
        {
            ResponseModel response = new ResponseModel();
            response = _authorService.Delete(id);

            return Task.FromResult(response);
        }
        [HttpPost]
        [Route("GetByAuthorId/{id}")]
        public Task<ResponseModel> GetByAuthorId(int id)
        {
            ResponseModel response = new ResponseModel();
            response = _authorService.GetById(id);

            return Task.FromResult(response);
        }

    }
}
