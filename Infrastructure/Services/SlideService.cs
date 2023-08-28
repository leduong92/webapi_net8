

using Core.DTO.RequestDto;
using Core.Entities;
using Core.Interfaces;
using Core.Model;
using Infrastructure.HelperService;
using Newtonsoft.Json;

namespace Infrastructure.Services;

public class SlideService : ISlideService
{
    private readonly IUnitOfWork _uow;
    public SlideService(IUnitOfWork uow)
    {
        _uow = uow;
    }


}
