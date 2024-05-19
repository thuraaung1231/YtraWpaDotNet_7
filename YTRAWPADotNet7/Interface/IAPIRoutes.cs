﻿using BookLibraryDTO.Model;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace YTRAWPADotNet7.Interface
{
    public interface IAPIRoutes
    {
        [Post("/Author/CreateAuthor")]
        Task<ResponseModel> CreateAuthor(AuthorEntity Author);

        [Get("/Author/ListAuthor")]
        Task<ResponseModel> AuthorList();

        [Post("/Author/DeleteAuthor/{id}")]
        Task<ResponseModel> DeleteAuthor(int id);

        [Post("/Author/GetByAuthorId/{id}")]
        Task<ResponseModel> GetByAuthorId(int id);

        [Post("/Author/UpdateAuthor")]
        Task<ResponseModel> UpdateAuthor(AuthorEntity authorEntity);
        //[Post("/Student/GetStudentById/{id}")]
        //Task<StudentModel> GetStudentById(int id);

        //[Post("/Student/UpdateStudent")]
        //Task<bool> UpdateStudent(StudentModel studentModel);

        //[Post("/Student/DeleteStudent/{id}")]
        //Task<bool> DeleteStudent(int id);
    }
}
