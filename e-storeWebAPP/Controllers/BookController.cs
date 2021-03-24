using AutoMapper;
using DataDomain.DataTables.Books;
using e_storeWebAPP.DTOModels;
using e_storeWebAPP.Repositories.UnitsofWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        #region Private Variables
        private readonly IUnitOfWork _uow;
        private readonly ILogger<BookController> _log;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public BookController(IUnitOfWork uow, ILogger<BookController> log, IMapper mapper)
        {
            _uow = uow;
            _log = log;
            _mapper = mapper;
        } 
        #endregion

        #region HttpGets

        //Get All
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBooks()
        {         
            var books = await _uow.Books.GetAll();
            var results = _mapper.Map<IList<BookDTO>>(books);
            return Ok(results);     
        }

        //Get By Id
        [HttpGet("{id:int}", Name = "GetBook")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _uow.Books.Get(q => q.Id == id);
            var result = _mapper.Map<BookDTO>(book);
            return Ok(result);
        }
        #endregion

        #region HttpPosts
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookDTO bookDTO)
        {

            if (!ModelState.IsValid)
            {
                _log.LogInformation($"Invalid POST attempt in {nameof(CreateBook)}");
                return BadRequest(ModelState);
            }

            var book = _mapper.Map<Book>(bookDTO);
            await _uow.Books.Insert(book);
            await _uow.Save();

            return CreatedAtRoute("GetBook", new { id = book.Id }, book);
        }
        #endregion

        #region HttpPut
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] UpdateBookDTO bookDTO)
        {

            if (!ModelState.IsValid || id < 1)
            {
                _log.LogInformation($"Invalid UPDATE attempt in {nameof(UpdateBook)}");
                return BadRequest(ModelState);
            }
  
            var country = await _uow.Books.Get(q => q.Id == id);
            if (country == null)
            {
                _log.LogInformation($"Invalid UPDATE attempt in {nameof(UpdateBook)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(bookDTO, country);
            _uow.Books.Update(country);
            await _uow.Save();

            return NoContent();
            
        }
        #endregion

        #region HttpDelete
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteBook(int id)
        {
            if (id < 1)
            {
                _log.LogError($"Invalid Delete attempt in {nameof(DeleteBook)}");
                return BadRequest();
            }

       
            var country = await _uow.Books.Get(q => q.Id == id);
            if (country == null)
            {
                _log.LogError($"Invalid Delete attempt in {nameof(DeleteBook)}");
                return BadRequest("Submitted data is invalid");
            }

            await _uow.Books.Delete(id);
            await _uow.Save();

            return NoContent();
            
        }
        #endregion

    }
}
