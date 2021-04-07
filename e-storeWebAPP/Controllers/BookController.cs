using Dapper;
using DataDomain.DataTables.Books;
using e_storeWebAPP.Repositories.UnitsofWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
        {   
            var response = await  _unitOfWork.GenericStoredProcedure.ReturnList<Book>("spGetAllBooks");  
                 
            return Ok(response);
        }

        [HttpGet("Genre")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByGenre(string genre)
        {
            DynamicParameters dynamicparameter = new DynamicParameters();
            dynamicparameter.Add("@Genre", genre, DbType.String, ParameterDirection.Input);

            var response = await _unitOfWork.GenericStoredProcedure.ReturnList<Book>("spGetBooksByGenre", parameters: dynamicparameter);

            return Ok(response);
        }

        [HttpGet("Category")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByCategory(string category)
        {
            DynamicParameters dynamicparameter = new DynamicParameters();
            dynamicparameter.Add("@Category", category, DbType.String, ParameterDirection.Input);

            var response = await _unitOfWork.GenericStoredProcedure.ReturnList<Book>("spGetBooksByCategory", parameters: dynamicparameter);

            return Ok(response);
        }

    }
}
