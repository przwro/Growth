﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Growth.UI.Controllers;
public abstract class BaseController : Controller
{
    private ISender _mediator;
    protected ISender Mediator => _mediator ??=
        HttpContext.RequestServices.GetService<ISender>();
}
