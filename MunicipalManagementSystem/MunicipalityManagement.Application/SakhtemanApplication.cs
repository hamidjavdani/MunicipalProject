using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.Sakhteman;
using MunicipalityManagement.Domain.SakhtemanAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Application;

public class SakhtemanApplication : ISakhtemanApplication
{
    private readonly ISakhtemanRepository _sakhtemanrepository;

    public SakhtemanApplication(ISakhtemanRepository sakhtemanrepository)
    {
        _sakhtemanrepository = sakhtemanrepository;
    }

    OperationResult ISakhtemanApplication.Create(CreateSakhteman command)
    {
        var operation = new OperationResult();
        //if (_melkrepository.Exists(x => x.Codenosazi == command.Codenosazi))
        //    return operation.Failed("خطا");

        var sakhteman = new Sakhteman(command.Idsakhteman,
            command.Idtabagheh, command.Idkarbari,
            command.Idestefadeh, command.Ideskelet,
            command.Idmarhalesakhtemani,
            command.Idnama, command.Idvahed,
            command.Salsakht, command.Tedadvahed,
            command.Masahat, command.Pishamadegi,
            command.Ertefah, command.Masahahttariz,
            command.Idmelk);

        _sakhtemanrepository.Create(sakhteman);
        _sakhtemanrepository.SaveChange();
        //_melkrepository.SaveChange();
        return operation.Succedded();
    }

    OperationResult ISakhtemanApplication.Edit(EditSakhteman command)
    {
        var operation = new OperationResult();
        var sakhteman = _sakhtemanrepository.Get(command.Id);
        if (sakhteman == null)
            return operation.Failed("رکورد یافت نشد");
        //  if (_sakhtemanrepository.Exists(x => x.Cnmantagheh == command.Cnmantagheh && x.Id != command.Id))
        //    return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد");
        sakhteman.Edit(command.Idsakhteman,
            command.Idtabagheh, command.Idkarbari,
            command.Idestefadeh, command.Ideskelet,
            command.Idmarhalesakhtemani,
            command.Idnama, command.Idvahed,
            command.Salsakht,
            command.Tedadvahed,
            command.Masahat,
            command.Pishamadegi,
            command.Ertefah,
            command.Masahahttariz,
            command.Idmelk);
        _sakhtemanrepository.Create(sakhteman);
        _sakhtemanrepository.SaveChange();
        return operation.Succedded();
    }

    EditSakhteman ISakhtemanApplication.GetDetails(long id)
    {
        return _sakhtemanrepository.GetDetails(id);
    }

    List<SakhtemanViewModel> ISakhtemanApplication.Search(long Id)
    {
        return _sakhtemanrepository.Search(Id);
    }
}
