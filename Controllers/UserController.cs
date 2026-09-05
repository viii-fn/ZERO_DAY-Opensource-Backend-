using Microsoft.AspNetCore.Mvc;

namespace ZERO_DAY.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UsersController : ControllerBase
{
	List<UserModel> userList = new List<UserModel>()
	{
		new UserModel()
		{
			Name = "VIII",
			Key = "2324",
			Id = 1
		},
		new UserModel()
		{
			Name = "XDR",
			Key = "2324",
			Id = 2
		},
		new UserModel()
		{
			Name = "FnFlume",
			Key = "2324",
			Id = 3
		}
	};
	
	[HttpGet]
	public IActionResult GetAll()
	{
		return Ok(userList);
	}

	// [HttpGet("[token]")]
}