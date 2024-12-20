using _0_Framework.Domain;
using MunicipalityManagement.Application.Contracts.Slide;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.SlideAgg;

public interface ISlideRepository : IRepository<long, Slide>
{
    EditSlide GetDetails(long id);
    List<SlideViewModel> GetList();
}
