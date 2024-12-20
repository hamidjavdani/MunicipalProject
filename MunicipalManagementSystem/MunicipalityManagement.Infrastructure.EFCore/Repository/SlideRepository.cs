using _0_Framework.Application;
using _0_Framework.Infrastructure;
using MunicipalityManagement.Application.Contracts.Slide;
using MunicipalityManagement.Domain.SlideAgg;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityManagement.Infrastructure.EFCore.Repository;

public class SlideRepository : RepositoryBase<long, Slide>, ISlideRepository
{
    private readonly MunicipalityContext _context;

    public SlideRepository(MunicipalityContext context) : base(context)
    {
        _context = context;
    }

    public EditSlide GetDetails(long id)
    {
        return _context.tblslid.Select(x => new EditSlide
        {
            Id = x.Id,
            BtnText = x.BtnText,
            Heading = x.Heading,
            PictureAlt = x.PictureAlt,
            PictureTitle = x.PictureTitle,
            Text = x.Text,
            Link = x.Link,
            Title = x.Title
        }).FirstOrDefault(x => x.Id == id);
    }

    public List<SlideViewModel> GetList()
    {
        return _context.tblslid.Select(x => new SlideViewModel
        {
            Id = x.Id,
            Heading = x.Heading,
            Picture = x.Picture,
            Title = x.Title,
            IsRemoved = x.IsRemoved,
            CreationDate = x.CreationDate.ToFarsi()
        }).OrderByDescending(x => x.Id).ToList();
    }
}
