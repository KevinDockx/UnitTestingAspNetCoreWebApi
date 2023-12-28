﻿using AutoMapper; 
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers;

[Route("api/statistics")]
[ApiController]
public class StatisticsController(IMapper mapper) : ControllerBase
{
    private readonly IMapper _mapper = mapper;

    [HttpGet] 
    public ActionResult<StatisticsDto> GetStatistics()
    {
        var httpConnectionFeature = HttpContext.Features.Get<IHttpConnectionFeature>();
        return Ok(_mapper.Map<StatisticsDto>(httpConnectionFeature));
    }
}
