using AutoMapper;
using eCommerceOrderService.DataAccessLayer.Entities;

namespace eCommerce.OrderMicroservice.BusinessLogicLayer.Mapping;

public class OrderUpdateRequestToOrderMappingProfile : Profile
{
    public OrderUpdateRequestToOrderMappingProfile()
    {
        CreateMap<DTO.OrderUpdateRequest, Order>()
            .ForMember(dest => dest.OrderID, opt => opt.MapFrom(src => src.OrderID))
            .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.UserID))
            .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => src.OrderDate))
            .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems))
            .ForMember(dest => dest._id, opt => opt.Ignore())
            .ForMember(dest => dest.TotalBill, opt => opt.Ignore());
    }
}