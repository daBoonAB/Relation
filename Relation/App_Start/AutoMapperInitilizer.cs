using AutoMapper;
using Relation.Core.Models;
using Relation.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relation
{
    public class AutoMapperInitilizer
    {
        public static void RegisterMapping()
        {
            Mapper.Configuration.RecognizeDestinationPrefixes("str", "bit", "int", "dbl", "txt","dtm");
            Mapper.Configuration.RecognizePrefixes("str", "bit", "int", "dbl", "txt","dtm");

            Mapper.CreateMap<tblCustomer, CustomerViewModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.customerID));
            Mapper.CreateMap<CustomerViewModel, tblCustomer>()
                .ForMember(dest => dest.customerID, opt => opt.MapFrom(src => src.ID));

            Mapper.CreateMap<tblCategory, CategoryViewModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.categoryID));
            Mapper.CreateMap<CategoryViewModel, tblCategory>()
                .ForMember(dest => dest.categoryID, opt => opt.MapFrom(src => src.ID));

            Mapper.CreateMap<tblCategoryType, InputViewModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.categoryTypeID));
            Mapper.CreateMap<InputViewModel, tblCategoryType>()
                .ForMember(dest => dest.categoryTypeID, opt => opt.MapFrom(src => src.ID));

            Mapper.CreateMap<tblCompany, CompanyViewModel>()
                 .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.companyID));
            Mapper.CreateMap<CompanyViewModel, tblCompany>()
                .ForMember(dest => dest.companyID, opt => opt.MapFrom(src => src.ID));

            Mapper.CreateMap<tblOrderUnit, OrderUnitViewModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.orderUnitID));
            Mapper.CreateMap<OrderUnitViewModel, tblOrderUnit>()
                .ForMember(dest => dest.orderUnitID, opt => opt.MapFrom(src => src.ID));


            //mappa orderviewmodel o order
            Mapper.CreateMap<tblOrder, OrderViewModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.orderID));

            Mapper.CreateMap<OrderViewModel, tblOrder>()
                .ForMember(dest => dest.orderID, opt => opt.MapFrom(src => src.ID));





        }
    }
}