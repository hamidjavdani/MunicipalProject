using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MunicipalityManagement.Application.Contracts.Darkhast;
using PersonManagement.Application.Contracts.Person;
using System.Collections.Generic;

namespace ServiceHost.Areas.UserAreas.Pages.Request;

public class Index1Model : PageModel
{
    public string Message { get; set; }
    public PersonSearchModel SearchModel;
    public List<DarkhastViewModel> Persons;
    private readonly IDarkhastApplication _personApplication;
    public Index1Model(IDarkhastApplication personApplication)
    {
        _personApplication = personApplication;
    }


    public void OnGet(DarkhastSearchModel searchModel)
    {
        //Roles = new SelectList(_roleApplication.List(), "Id", "Name");
        Persons = _personApplication.Search(searchModel);
    }

    public IActionResult OnGetCreate()
    {
        var command = new CreatePerson();
        //  command.karbarit= _melkApplication.GetKarbari();
        //command.Name=
        return Partial("./Create", new CreatePerson());

    }


    public JsonResult OnPostCreate(CreateDarkhast command)
    {
        var result = _personApplication.Create(command);
        return new JsonResult(result);
    }
    public IActionResult OnGetEdit(long id)
    {
        var Persons = _personApplication.GetDetails(id);
        return Partial("Edit", Persons);

    }
    public JsonResult OnPostEdit(EditDarkhast command)
    {
        var result = _personApplication.Edit(command);
        return new JsonResult(result);
    }


    //public IActionResult OnGetRemove(long id)
    //{
    //    var result = _personApplication.Remove(id);
    //    if (result.IsSuccedded)
    //        return RedirectToPage("./Index");

    //    Message = result.Message;
    //    return RedirectToPage("./Index");
    //}

    //public IActionResult OnGetRestore(long id)
    //{
    //    var result = _personApplication.Restore(id);
    //    if (result.IsSuccedded)
    //        return RedirectToPage("./Index");

    //    Message = result.Message;
    //    return RedirectToPage("./Index");
    //}


}
