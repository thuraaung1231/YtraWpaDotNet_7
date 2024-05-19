using BookLibraryDTO.DAO;
using BookLibraryDTO.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryDTO.Services
{
    public class AuthorService
    {
        public readonly MyDbContext _dbContext;
        public readonly DbSet<AuthorEntity> _dbset;
        public AuthorService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbset = _dbContext.Set<AuthorEntity>();
        }
        public ResponseModel Create(AuthorEntity author) { 
        ResponseModel response = new ResponseModel();

            _dbset.Add(author);
           var result= _dbContext.SaveChanges();

            response.resCode = result>0 ? "I0001" : "I0002";
           
            return response;
        }
        public ResponseModel list() 
        {

            ResponseModel response = new();

            List<AuthorEntity> userList = _dbset.Where(s => s.is_delete == false).ToList();
            response.resData = userList;
           
            response.resCode = userList != null ? "success " : "fail";
            return (response);
        }
        public ResponseModel GetById(int id)
        {
            ResponseModel response = new ResponseModel();

            response.resData = _dbset.Find(id);

            response.resCode = response.resData != null ? "I0001" : "I0002";


            return response;
        }
        public ResponseModel Delete(int id) { 
        ResponseModel response= new ResponseModel();

            var getdata = _dbset.Find(id);
            if (getdata == null)
            {
                response.resCode = "I0003";
                return response;
            }

            getdata.is_delete = true;
            _dbset.Update(getdata);
            var result = _dbContext.SaveChanges();

            response.resCode = result >= 0 ? "I0001" : "I0002";

            return response;


        }
        public ResponseModel Update(AuthorEntity author) { 
        ResponseModel response = new ResponseModel();

            _dbContext.Update(author);
            var result =_dbContext.SaveChanges();

            response.resCode = result >= 0 ? "I0001" : "I0002";
        
            return response;
        }

       
    }
}
