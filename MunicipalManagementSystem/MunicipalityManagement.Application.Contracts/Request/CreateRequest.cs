using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.TitleRequest;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MunicipalityManagement.Application.Contracts.Request;

public class CreateRequest
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long AccountId { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int RequestType { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Codemelk { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string IssueTrackingNo { get; set; }  //شماره پیگیری


    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnmantagheh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnhozeh { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnblock { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Cnmelk { get; set; }

    public List<TitleRequestViewModel> TitleRequests { get; set; }

}
