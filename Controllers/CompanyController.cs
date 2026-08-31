using Microsoft.AspNetCore.Mvc;

namespace ZERO_DAY.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
	[HttpGet]
	public IEnumerable<string> Get()
	{
		return new string[] { "Vidpixar", "SerzaMoon", "Zero Day", "Paramedy" };
	}
}