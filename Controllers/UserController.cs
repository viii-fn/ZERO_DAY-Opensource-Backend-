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
			new UserModel() { },
			new UserModel() { }
		}
		return Ok(userList);
	}
}