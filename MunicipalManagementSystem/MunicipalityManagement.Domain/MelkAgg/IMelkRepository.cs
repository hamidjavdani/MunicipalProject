using _0_Framework.Domain;
using MunicipalityManagement.Application.Contracts.Melk;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.MelkAgg;

public interface IMelkRepository : IRepository<long, Melk>
{
    EditMelk GetDetails(long id);
    List<MelkViewModel> Search(MelkSearchModel search);



}
