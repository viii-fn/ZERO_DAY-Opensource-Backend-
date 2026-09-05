using Microsoft.AspNetCore.Mvc;

namespace ZERO_DAY.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UsersController : ControllerBase
{
	private List<UserModel> UserList;
	public UsersController()
	{
		UserList = new List<UserModel>()
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
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		return Ok(UserList);
	}

	[HttpGet("{id}")]
	public IActionResult GetById(int id)
	{
		var singleUser = UserList.FirstOrDefault(x => x.Id == id);
		if (singleUser == null)
		{
			return NotFound();
		}
		return Ok(singleUser);
	}

	[HttpPost("new")]
	public IActionResult Post(UserModel model)
	{
		if (!ModelState.isValid)
		{
			return BadRequest();
		}
		model.Id = UserList.Max(x => x.Id + 1);
		UserList.Add(model);

		return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
	}
}