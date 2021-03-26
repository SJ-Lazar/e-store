using AutoMapper;
using DataDomain.DataTables.Base;
using DataDomain.DataTables.Books;
using DataDomain.DataTables.Sales;
using DataDomain.DataTables.Transactions;
using e_storeWebAPP.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.Mapper
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<Book, CreateBookDTO>().ReverseMap();
            CreateMap<SaleItem, SaleItemDTO>().ReverseMap();
            CreateMap<SaleItem, CreateSaleItemDTO>().ReverseMap();
            CreateMap<Invoice, InvoiceDTO>().ReverseMap();
            CreateMap<Invoice, CreateInvoiceDTO>().ReverseMap();
            CreateMap<Receipt, ReceiptDTO>().ReverseMap();
            CreateMap<Receipt, CreateReceiptDTO>().ReverseMap();
            CreateMap<Tax, TaxDTO>().ReverseMap();
            CreateMap<Tax, CreateTaxDTO>().ReverseMap();
            CreateMap<Discount, DiscountDTO>().ReverseMap();
            CreateMap<Discount, CreateDiscountDTO>().ReverseMap();
            CreateMap<User, RegisterUserDTO>().ReverseMap();
            CreateMap<User, LoginUserDTO>().ReverseMap();
            CreateMap<User, ConfirmEmailUserDTO>().ReverseMap();
        }
    }
}
