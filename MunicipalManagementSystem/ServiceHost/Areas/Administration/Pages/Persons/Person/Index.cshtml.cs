using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonManagement.Application.Contracts.Person;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Persons.Person;

public class IndexModel : PageModel
{
    public string Message { get; set; }
    public PersonSearchModel SearchModel;
    public List<PersonViewModel> Persons;
    private readonly IPersonApplication _personApplication;
    public IndexModel(IPersonApplication personApplication)
    {
        _personApplication = personApplication;
    }


    public void OnGet(PersonSearchModel searchModel)
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


    public JsonResult OnPostCreate(CreatePerson command)
    {
        var result = _personApplication.Create(command);
        return new JsonResult(result);
    }
    public IActionResult OnGetEdit(long id)
    {
        var Persons = _personApplication.GetDetails(id);
        return Partial("Edit", Persons);

    }
    public JsonResult OnPostEdit(EditPerson command)
    {
        var result = _personApplication.Edit(command);
        return new JsonResult(result);
    }


    public IActionResult OnGetRemove(long id)
    {
        var result = _personApplication.Remove(id);
        if (result.IsSuccedded)
            return RedirectToPage("./Index");

        Message = result.Message;
        return RedirectToPage("./Index");
    }

    public IActionResult OnGetRestore(long id)
    {
        var result = _personApplication.Restore(id);
        if (result.IsSuccedded)
            return RedirectToPage("./Index");

        Message = result.Message;
        return RedirectToPage("./Index");
    }




}

