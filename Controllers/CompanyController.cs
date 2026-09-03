using Microsoft.AspNetCore.Mvc;

namespace ZERO_DAY.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
	[HttpGet]
	public ActionResult<string> GetCompany()
	{
		return new string[] { "Vidpixar", "SerzaMoon", "Zero Day", "Paramedy" };
	}
}