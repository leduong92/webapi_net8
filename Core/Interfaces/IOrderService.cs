using Core.DTO.RequestDto;
using Core.DTO.ResponseDto;
using Core.Entities;
using Core.Model;

namespace Core.Interfaces
{
    public interface IOrderService
    {
        Task<OrderResponseDto> CreateOrder(OrderRequestDto request);
    }
}