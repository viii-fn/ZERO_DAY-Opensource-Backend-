using Microsoft.AspNetCore.Mvc;

namespace ZERO_DAY.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
	[HttpGet]
	[Route("[action]")]
	public ActionResult<string> GetCompany()
	{
		return "Vidpixar";
	}
}