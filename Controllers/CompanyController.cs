[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
	[HttpGet]
	public IEnumerable Get()
	{
		return new string[] { "Vidpixar", "SerzaMoon", "Paramedy" };
	}
}