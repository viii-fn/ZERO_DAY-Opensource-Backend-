using Microsoft.AspNetCore.Mvc;

namespace ZERO_DAY.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase
{
	[HttpGet]
	public IActionResult GetAll()
	{
		var userList = new List<UserModel>()
		{
			new UserModel()
			{
				Username = "VIII",
				Password = "2324#Dream",
				Token = 232413579
			}
		};
		return Ok(userList);
	}
}