using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MunicipalityManagement.Application.Contracts.ListBox;
using MunicipalityManagement.Application.Contracts.ListBoxCategory;
using MunicipalityManagement.Application.Contracts.Melk;
using PersonManagement.Application.Contracts.Person;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Municipality.Melk;

public class IndexModel : PageModel
{
    public ListBoxCategorySearchModel SearchModel;
    public List<MelkViewModel> melkcategories;
    private readonly IListBoxApplication _listBoxApplication;
    public SelectList _listboxs;
    private readonly IPersonApplication _personApplication;
    private readonly IMelkApplication _melkApplication;

    public IndexModel(IMelkApplication melkApplication,
         IListBoxApplication listBoxApplication
        )
    {
        _melkApplication = melkApplication;
        _listBoxApplication = listBoxApplication;
    }

    public void OnGet(MelkSearchModel searchModel)
    {
        melkcategories = _melkApplication.Search(searchModel);
    }

    public IActionResult OnGetCreate()
    {
        //var command = new CreateMelk();
        //  command.karbarit= _melkApplication.GetKarbari();
        // return Partial("./Create", command);

        var command = new CreateMelk
        {
            ListBoxtypesanad = _listBoxApplication.GetListBoxs(2),
            ListBoxkarbaritarhejameh = _listBoxApplication.GetListBoxs(1),
            ListBoxstatemelk = _listBoxApplication.GetListBoxs(3),
            ListBoxpahnehtarhejameh = _listBoxApplication.GetListBoxs(3),
            ListBoxhamjavari = _listBoxApplication.GetListBoxs(7),
            ListBoxzaribpahneh = _listBoxApplication.GetListBoxs(8),
            ListBoxkarbaribaft = _listBoxApplication.GetListBoxs(5),
            ListBoxkarbaripahnehbaft = _listBoxApplication.GetListBoxs(4),
            ListBoxtarhehtafzili = _listBoxApplication.GetListBoxs(6)
        };
        return Partial("./Create", command);

    }

    //public IActionResult OnGetCreateSakhteman()
    //{
    //    return Partial("./Sakhteman", "");

    //}


    public IActionResult OnGetCreateMalek()
    {
        var command = new CreatePerson();
        //  command.karbarit= _melkApplication.GetKarbari();
        //command.Name=
        return Partial("./Createmalek", new CreatePerson());

    }


    public JsonResult OnPostCreateMalek(CreatePerson command)
    {
        var result = _personApplication.Create(command);
        return new JsonResult(result);
    }


    public JsonResult OnPostCreate(CreateMelk command)
    {
        var result = _melkApplication.Create(command);
        return new JsonResult(result);
    }
    public IActionResult OnGetEdit(long id)
    {
        var melk = _melkApplication.GetDetails(id);
        melk.ListBoxtypesanad = _listBoxApplication.GetListBoxs(2);
        melk.ListBoxkarbaritarhejameh = _listBoxApplication.GetListBoxs(1);
        melk.ListBoxstatemelk = _listBoxApplication.GetListBoxs(3);
        melk.ListBoxpahnehtarhejameh = _listBoxApplication.GetListBoxs(3);
        melk.ListBoxhamjavari = _listBoxApplication.GetListBoxs(7);
        melk.ListBoxzaribpahneh = _listBoxApplication.GetListBoxs(8);
        melk.ListBoxkarbaribaft = _listBoxApplication.GetListBoxs(5);
        melk.ListBoxkarbaripahnehbaft = _listBoxApplication.GetListBoxs(4);
        melk.ListBoxtarhehtafzili = _listBoxApplication.GetListBoxs(6);
        return Partial("Edit", melk);

    }
    public JsonResult OnPostEdit(EditMelk command)
    {
        var result = _melkApplication.Edit(command);
        return new JsonResult(result);
    }



}
