using _0_Framework.Application;
using PersonManagement.Application.Contracts.Person;
using PersonManagement.Domain.PersonAgg;
using System;
using System.Collections.Generic;

namespace PersonManagement.Application;

public class PersonApplication : IPersonApplication
{
    private readonly IPersonRepository _personrepository;
    private readonly IFileUploader _fileUploader;
    public PersonApplication(IPersonRepository personrepository,
        IFileUploader fileUploader)
    {
        _personrepository = personrepository;
        _fileUploader = fileUploader;
    }

    public OperationResult Create(CreatePerson command)
    {
        var operation = new OperationResult();
        if (_personrepository.Exists(x => x.MelliCode == command.MelliCode))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var path = $"profilePhotos";
        var picturePath = _fileUploader.Upload(command.ImagePath, path);

        var person = new Person(

        command.FirstName,
        command.LastName,
        command.MelliCode,
        command.Shenasnameh,
        command.Parent,
        command.BirthDayDate,
        command.Mobile,
        command.Gender,
        picturePath,
        command.SignaturePath
            );
        _personrepository.Create(person);
        _personrepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult Edit(EditPerson command)
    {
        var operation = new OperationResult();
        var person = _personrepository.Get(command.Id);
        if (person == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);
        if (_personrepository.Exists(x => x.MelliCode == command.MelliCode && x.Id != command.Id))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var path = $"profilePhotos";
        var picturePath = _fileUploader.Upload(command.ImagePath, path);
        person.Edit(command.FirstName,
        command.LastName,
        command.MelliCode,
        command.Shenasnameh,
        command.Parent,
        command.BirthDayDate,
        command.Mobile,
        command.Gender,
        picturePath,
        command.SignaturePath

        );
        _personrepository.SaveChange();
        return operation.Succedded();

    }

    public EditPerson GetDetails(long id)
    {
        return _personrepository.GetDetails(id);
    }

    public OperationResult IsStock(long id)
    {
        var operation = new OperationResult();
        var person = _personrepository.Get(id);
        if (person == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);

        _personrepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult NotInStock(long id)
    {
        throw new NotImplementedException();
    }

    public OperationResult Remove(long id)
    {
        var operation = new OperationResult();
        var person = _personrepository.Get(id);
        if (person == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);

        person.Remove();
        _personrepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult Restore(long id)
    {
        var operation = new OperationResult();
        var person = _personrepository.Get(id);
        if (person == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);

        person.Restore();
        _personrepository.SaveChange();
        return operation.Succedded();
    }

    public List<PersonViewModel> Search(PersonSearchModel searchModel)
    {
        return _personrepository.Search(searchModel);
    }
}
