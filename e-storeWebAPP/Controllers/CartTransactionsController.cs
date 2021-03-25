using AutoMapper;
using DataDomain.DataTables.Transactions;
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
    public class CartTransactionsController : ControllerBase
    {
        #region Private Variables
        private readonly IUnitOfWork _uow;
        private readonly ILogger<CartTransactionsController> _log;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public CartTransactionsController(IUnitOfWork uow, ILogger<CartTransactionsController> log, IMapper mapper)
        {
            _uow = uow;
            _log = log;
            _mapper = mapper;
        }
        #endregion

        #region HttpPosts
        [HttpPost("Invoice")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateInvoice([FromBody] CreateInvoiceDTO invoiceDTO)
        {

            if (!ModelState.IsValid)
            {
                _log.LogInformation($"Invalid POST attempt in {nameof(CreateInvoice)}");
                return BadRequest(ModelState);
            }

            var invoice = _mapper.Map<Invoice>(invoiceDTO);
            await _uow.Invoices.Insert(invoice);
            await _uow.Save();

            //return CreatedAtRoute("GetInvoice", new { id = invoice.Id }, invoice);
            return Ok();
        }


        [HttpPost("Receipt")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateReceipt([FromBody] CreateReceiptDTO receiptDTO)
        {

            if (!ModelState.IsValid)
            {
                _log.LogInformation($"Invalid POST attempt in {nameof(CreateReceipt)}");
                return BadRequest(ModelState);
            }

            var receipt = _mapper.Map<Receipt>(receiptDTO);
            await _uow.Receipts.Insert(receipt);
            await _uow.Save();

            //return CreatedAtRoute("GetReceipt", new { id = receipt.Id }, receipt);
            return Ok();
        }
        #endregion
    }
}
