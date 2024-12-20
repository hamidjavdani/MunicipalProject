using Microsoft.AspNetCore.Mvc;
using MunicipalityManagement.Application.Contracts.TitleRequest;
using System.Collections.Generic;

namespace ServiceHost.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RequestController : ControllerBase
{
    private readonly ITitleRequestApplication _titelRequest;

    public RequestController(ITitleRequestApplication titelRequest)
    {
        _titelRequest = titelRequest;
    }

    [HttpGet]
    public List<TitleRequestViewModel> GetTitleRequest()
    {
        return _titelRequest.GetTitleRequest();
    }

}
