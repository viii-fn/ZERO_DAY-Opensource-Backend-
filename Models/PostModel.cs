using System.ComponentModel.DataAnnotations;

public class PostModel
{
	int Id { get; set; }
	[Required]
	public string Post { get; set; }
}