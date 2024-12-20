using _0_Framework.Application;
using System;
using System.ComponentModel.DataAnnotations;
namespace AccountManagement.Application.Contracts.AccountJob;

public class CreateAccountJob
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long AccountId { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public long JobId { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public DateTime StartJobName { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public DateTime EndJobName { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public bool IsHaveJob { get; private set; }
}
