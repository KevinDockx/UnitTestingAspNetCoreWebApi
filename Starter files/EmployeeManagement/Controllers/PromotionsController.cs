using EmployeeManagement.Business;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers;

[Route("api/promotions")]
[ApiController]
public class PromotionsController(IEmployeeService employeeService,
    IPromotionService promotionService) : ControllerBase
{
    private readonly IEmployeeService _employeeService = employeeService;
    private readonly IPromotionService _promotionService = promotionService;

    [HttpPost]
    public async Task<IActionResult> CreatePromotion(PromotionForCreationDto promotionForCreation)
    { 
        var internalEmployeeToPromote = await _employeeService
            .FetchInternalEmployeeAsync(promotionForCreation.EmployeeId);

        if (internalEmployeeToPromote == null)
        {
            return BadRequest();
        } 

        if (await _promotionService.PromoteInternalEmployeeAsync(internalEmployeeToPromote))
        {
            return Ok(new PromotionResultDto() 
                        { EmployeeId = internalEmployeeToPromote.Id, 
                         JobLevel = internalEmployeeToPromote.JobLevel });
        }
        else
        {
            return BadRequest("Employee not eligible for promotion.");
        }              
    }
}
