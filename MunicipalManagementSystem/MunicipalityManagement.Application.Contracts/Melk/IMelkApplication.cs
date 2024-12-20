using _0_Framework.Application;
using System.Collections.Generic;

namespace MunicipalityManagement.Application.Contracts.Melk;

public interface IMelkApplication
{
    OperationResult Create(CreateMelk command);
    OperationResult Edit(EditMelk command);
    OperationResult EditKarbari(EditMelk command);
    OperationResult EditKarbaribaft(EditMelk command);
    EditMelk GetDetails(long id);
    List<MelkViewModel> Search(MelkSearchModel searchModel);


}
