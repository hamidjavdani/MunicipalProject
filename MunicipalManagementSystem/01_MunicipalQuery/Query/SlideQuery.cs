using _01_MunicipalQuery.Query;
using MunicipalityManagement.Infrastructure.EFCore;
using System.Collections.Generic;
using System.Linq;

namespace _01_MunicipalQuery.Contracts.Slide;

public class SlideQuery : ISlideQuery
{
    private readonly MunicipalityContext _municipalityContext;

    public SlideQuery(MunicipalityContext municipalityContext)
    {
        _municipalityContext = municipalityContext;
    }

    public List<SlideQueryModel> GetSlides()
    {
        return _municipalityContext.tblslid
            .Where(x => x.IsRemoved == false)
            .Select(x => new SlideQueryModel
            {
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                BtnText = x.BtnText,
                Heading = x.Heading,
                Link = x.Link,
                Text = x.Text,
                Title = x.Title
            }).ToList();
    }
}
