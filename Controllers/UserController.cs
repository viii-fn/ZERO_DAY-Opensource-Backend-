using Microsoft.AspNetCore.Mvc;

namespace ZERO_DAY.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UsersController : ControllerBase
{
	private List<UserModel> UserList;
	public UsersController()
	{
		UserList = new List<UserModel>() {
			new UserModel()
			{
				Name = "viii_fn",
				Key = "jojoXR2324",
				Id = 1
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
		model.Id = UserList.Max(x => x.Id + 1);
		UserList.Add(model);

		return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
	}

	[HttpHead("{id}")]
	public IActionResult CheckIfExists(int id)
	{
		var userToReturn = UserList.FirstOrDefault(x => x.Id == id);
		if (userToReturn == null)
		{
			return NotFound();
		}
		return Ok(userToReturn);
	}
}