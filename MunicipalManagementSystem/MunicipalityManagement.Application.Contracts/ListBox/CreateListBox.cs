using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.ListBoxCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MunicipalityManagement.Application.Contracts.ListBox;

public class CreateListBox
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Name { get; set; }

    [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
    public long CategoryId { get; set; }
    public List<ListBoxCategoryViewModel> Categories { get; set; }

}
