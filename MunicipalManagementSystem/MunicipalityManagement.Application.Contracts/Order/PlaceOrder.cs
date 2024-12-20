using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.Darkhast;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MunicipalityManagement.Application.Contracts.Order;

public class PlaceOrder
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long AccountId { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int RequestType { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnmantagheh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnhozeh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnblock { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnmelk { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public bool IsCanceled { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string IssueTrackingNo { get; set; }//شماره پیگیری

    public List<DarkhastViewModel> ListRequest { get; set; }

}
