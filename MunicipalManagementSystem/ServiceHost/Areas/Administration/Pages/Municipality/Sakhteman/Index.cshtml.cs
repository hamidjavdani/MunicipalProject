using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MunicipalityManagement.Application.Contracts.ListBox;
using MunicipalityManagement.Application.Contracts.Sakhteman;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Municipality.Sakhteman;

public class IndexModel : PageModel
{
    public string Message { get; set; }
    public List<ListBoxViewModel> ListBoxtypesanad;
    //public CreateMelk CommandSakhteman;
    public CreateSakhteman CommandSakhteman;
    private readonly IListBoxApplication _listBoxApplication;
    private readonly ISakhtemanApplication _sakhtemanApplication;
    public SakhtemanSearchModel searchModel;
    public List<SakhtemanViewModel> sakhtemancategories;
    public IndexModel(ISakhtemanApplication sakhtemanApplication,
         IListBoxApplication listBoxApplication
        )
    {
        _sakhtemanApplication = sakhtemanApplication;
        _listBoxApplication = listBoxApplication;
    }

    //public SakhtemanModel(IListBoxApplication listBoxApplication)
    //{
    //    _listBoxApplication = listBoxApplication;
    //}


    public void OnGet(long id)
    {
        // var ListBoxCategorySearchModel searchModel;
        sakhtemancategories = _sakhtemanApplication.Search(id);
        ListBoxtypesanad = _listBoxApplication.GetListBoxs(2);
        CommandSakhteman = _sakhtemanApplication.GetDetails(id);
    }


    public IActionResult OnGetCreate()
    {
        //var command = new CreateMelk();
        //  command.karbarit= _melkApplication.GetKarbari();
        // return Partial("./Create", command);

        var command = new CreateSakhteman
        {
            //ListBoxtabagheh = _listBoxApplication.GetListBoxs(2),
            //ListBoxkarbari = _listBoxApplication.GetListBoxs(1),
            //ListBoxestefadeh = _listBoxApplication.GetListBoxs(3),
            //ListBoxeskelet = _listBoxApplication.GetListBoxs(3),
            //ListBoxmarhalesakhtemani = _listBoxApplication.GetListBoxs(7)

        };
        return Partial("./Create", command);

    }

    public JsonResult OnPostCreate(CreateSakhteman command)
    {
        var result = _sakhtemanApplication.Create(command);
        return new JsonResult(result);
    }
    public IActionResult OnGetEdit(long id)
    {
        var sakhteman = _sakhtemanApplication.GetDetails(id);
        //sakhteman.ListBoxtypesanad = _listBoxApplication.GetListBoxs(2);
        //sakhteman.ListBoxkarbaritarhejameh = _listBoxApplication.GetListBoxs(1);
        //sakhteman.ListBoxstatemelk = _listBoxApplication.GetListBoxs(3);
        //sakhteman.ListBoxpahnehtarhejameh = _listBoxApplication.GetListBoxs(3);
        //sakhteman.ListBoxhamjavari = _listBoxApplication.GetListBoxs(7);
        //sakhteman.ListBoxzaribpahneh = _listBoxApplication.GetListBoxs(8);
        //sakhteman.ListBoxkarbaribaft = _listBoxApplication.GetListBoxs(5);
        //sakhteman.ListBoxkarbaripahnehbaft = _listBoxApplication.GetListBoxs(4);           
        return Partial("Edit", sakhteman);

    }
    public JsonResult OnPostEdit(EditSakhteman command)
    {
        var result = _sakhtemanApplication.Edit(command);
        return new JsonResult(result);
    }




}


