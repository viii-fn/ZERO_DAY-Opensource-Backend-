using Microsoft.AspNetCore.Mvc;

namespace ZERO_DAY.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UsersController : ControllerBase
{
	[HttpGet]
	public IActionResult GetAll()
	{
		List<UserModel> userList = new List<UserModel>()
		{
			new UserModel()
			{
				Name = "VIII",
				Key = "2324",
				Id = 1
			}
		};
		return Ok(userList);
	}

	// [HttpGet("[token]")]
}