using Microsoft.AspNetCore.Mvc;

namespace ZERO_DAY.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
	private List<PostModel> Posts;
	public PostController()
	{
		Posts = new List<PostModel>()
		{
			new PostModel()
			{
				Id = 1,
				Post = "Welcome to ZERO_DAY"
			}
		};
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		return Ok(Posts);
	}

	[HttpGet("{id}")]
	public IActionResult GetById(int id)
	{
		var post = Posts.FirstOrDefault(x => x.Id == id);
		if (post == null)
		{
			return NotFound();
		}

		return Ok(post);
	}

	[HttpPost]
	public IActionResult Post(PostModel newPost)
	{
		newPost.Id = Posts.Max(x => x.Id + 1);
		Posts.Add(newPost);

		return CreatedAtAction(nameof(GetById), new { id = newPost.Id }, newPost);
	}
}