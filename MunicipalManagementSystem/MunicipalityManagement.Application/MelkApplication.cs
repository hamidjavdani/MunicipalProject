using _0_Framework.Application;

using MunicipalityManagement.Application.Contracts.Melk;
using MunicipalityManagement.Domain.MelkAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Application;

public class MelkApplication : IMelkApplication
{
    private readonly IMelkRepository _melkrepository;

    public MelkApplication(IMelkRepository melkrepository)
    {
        _melkrepository = melkrepository;
    }

    public OperationResult Create(CreateMelk command)
    {
        var operation = new OperationResult();
        if (_melkrepository.Exists(x => x.Cnmantagheh == command.Cnmantagheh))
            return operation.Failed("خطا");
        var melk = new Melk(command.Cnmantagheh, command.Cnhozeh, command.Cnblock,
            command.Cnmelk, command.Cnmantaghehold, command.Cnhozehold, command.Cnblockold,
            command.Cnmelkold, command.Masahatsanad, command.Masahateslahi, command.Idtypesanad,
            command.Idtarakompayeh, command.Idkarbaritarhejameh, command.Idstatemelk, command.Idpahnehtarhejameh,
            command.Idhamjavari, command.Idzaribpahneh, command.Idkarbaribaft,
            command.Idkarbaripahnehbaft, command.Idtarhehtafzili, command.baftfarsudeh,
            command.baftkohan, command.Address, command.pelakasli,
            command.pelakfarei1, command.pelakfarei2, command.Tozihat);

        _melkrepository.Create(melk);
        _melkrepository.SaveChange();

        return operation.Succedded();


    }

    public OperationResult Edit(EditMelk command)
    {
        var operation = new OperationResult();
        var melk = _melkrepository.Get(command.Id);
        if (melk == null)
            return operation.Failed("رکورد یافت نشد");
        if (_melkrepository.Exists(x => x.Cnmantagheh == command.Cnmantagheh && x.Id != command.Id))
            return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد");
        melk.Edit(command.Cnmantagheh, command.Cnhozeh, command.Cnblock,
            command.Cnmelk, command.Cnmantaghehold, command.Cnhozehold, command.Cnblockold,
            command.Cnmelkold, command.Masahatsanad, command.Masahateslahi, command.Idtypesanad,
            command.Idtarakompayeh, command.Idkarbaritarhejameh, command.Idstatemelk, command.Idpahnehtarhejameh,
            command.Idhamjavari, command.Idzaribpahneh, command.Idkarbaribaft,
            command.Idkarbaripahnehbaft, command.Idtarhehtafzili, command.baftfarsudeh,
            command.baftkohan, command.Address, command.pelakasli,
            command.pelakfarei1, command.pelakfarei2, command.Tozihat);
        _melkrepository.SaveChange();
        return operation.Succedded();

    }
    public OperationResult EditKarbari(EditMelk command)
    {
        var operation = new OperationResult();
        var melk = _melkrepository.Get(command.Id);
        if (melk == null)
            return operation.Failed("رکورد یافت نشد");
        if (_melkrepository.Exists(x => x.Cnmantagheh == command.Cnmantagheh && x.Id != command.Id))
            return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد");
        melk.EditKarbari(command.Cnmantagheh, command.Cnhozeh, command.Cnblock,
            command.Cnmelk, command.Cnmantaghehold, command.Cnhozehold, command.Cnblockold,
            command.Cnmelkold, command.Masahatsanad, command.Masahateslahi, command.Idtypesanad,
            command.Idtarakompayeh, command.Idkarbaritarhejameh, command.Idstatemelk, command.Idpahnehtarhejameh,
            command.Idhamjavari, command.Idzaribpahneh, command.Idkarbaribaft,
            command.Idkarbaripahnehbaft, command.Idtarhehtafzili, command.baftfarsudeh,
            command.baftkohan, command.Address, command.pelakasli,
            command.pelakfarei1, command.pelakfarei2, command.Tozihat);
        _melkrepository.SaveChange();
        return operation.Succedded();

    }
    public OperationResult EditKarbaribaft(EditMelk command)
    {
        var operation = new OperationResult();
        var melk = _melkrepository.Get(command.Id);
        if (melk == null)
            return operation.Failed("رکورد یافت نشد");
        if (_melkrepository.Exists(x => x.Cnmantagheh == command.Cnmantagheh && x.Id != command.Id))
            return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد");
        melk.EditKarbaribaft(command.Cnmantagheh, command.Cnhozeh, command.Cnblock,
            command.Cnmelk, command.Cnmantaghehold, command.Cnhozehold, command.Cnblockold,
            command.Cnmelkold, command.Masahatsanad, command.Masahateslahi, command.Idtypesanad,
            command.Idtarakompayeh, command.Idkarbaritarhejameh, command.Idstatemelk, command.Idpahnehtarhejameh,
            command.Idhamjavari, command.Idzaribpahneh, command.Idkarbaribaft,
            command.Idkarbaripahnehbaft, command.Idtarhehtafzili, command.baftfarsudeh,
            command.baftkohan, command.Address, command.pelakasli,
            command.pelakfarei1, command.pelakfarei2, command.Tozihat);
        _melkrepository.SaveChange();
        return operation.Succedded();

    }

    public EditMelk GetDetails(long id)
    {
        return _melkrepository.GetDetails(id);
    }


    public List<MelkViewModel> Search(MelkSearchModel searchModel)
    {
        return _melkrepository.Search(searchModel);
    }


}
