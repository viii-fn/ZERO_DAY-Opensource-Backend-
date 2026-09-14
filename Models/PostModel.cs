using System.ComponentModel.DataAnnotations;

public class PostModel
{
	[Required]
	public int Id { get; set; }
	[Required]
	public string Post { get; set; }
}