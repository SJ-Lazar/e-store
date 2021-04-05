using DataDomain.DataTables.Books;
using e_storeWebAPP.Repositories.UnitsofWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public async Task<ActionResult<IEnumerable<Book>>> GetBattleCards()
        {
            var response = await  _unitOfWork.GenericStoredProcedure.ReturnList<Book>("spGetAllBooks");
            return Ok(response);
        }
    }
}
