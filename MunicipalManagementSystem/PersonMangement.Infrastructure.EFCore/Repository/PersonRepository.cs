using _0_Framework.Application;
using _0_Framework.Infrastructure;
using PersonManagement.Application.Contracts.Person;
using PersonManagement.Domain.PersonAgg;
using System.Collections.Generic;
using System.Linq;

namespace PersonMangement.Infrastructure.EFCore.Repository;

public class PersonRepository : RepositoryBase<long, Person>, IPersonRepository
{
    private readonly PersonContext _context;

    public PersonRepository(PersonContext context) : base(context)
    {
        _context = context;
    }

    public EditPerson GetDetails(long id)
    {
        return _context.Persons.Select(x => new EditPerson
        {
            Id = x.Id,
            LastName = x.LastName,
            FirstName = x.FirstName,
            Parent = x.Parent,
            MelliCode = x.MelliCode,
            Gender = x.Gender,
            Mobile = x.Mobile,
            BirthDayDate = x.BirthDayDate,
            Shenasnameh = x.Shenasnameh
        }).FirstOrDefault(x => x.Id == id);
    }

    public List<PersonViewModel> Search(PersonSearchModel searchModel)
    {
        var query = _context.Persons.Select(x => new PersonViewModel
        {
            Id = x.Id,
            LastName = x.LastName,
            FirstName = x.FirstName,
            CreationDate = x.CreationDate.ToFarsi(),
            ImagePath = x.ImagePath,
            MelliCode = x.MelliCode,
            //Mobile = x.Mobile,
            IsActive = x.IsActive,
            Shenasnameh = x.Shenasnameh

        });
        if (!string.IsNullOrWhiteSpace(searchModel.LastName))
            query = query.Where(x => x.LastName.Contains(searchModel.LastName));
        return query.OrderByDescending(x => x.Id).ToList();

    }
}
