using _01_MunicipalQuery.Contracts.Slide;
using System.Collections.Generic;

namespace _01_MunicipalQuery.Query;

public interface ISlideQuery
{
    List<SlideQueryModel> GetSlides();
}
