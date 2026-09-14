using System.ComponentModel.DataAnnotations;

public class PostModel
{
	public int Id { get; set; }
	[Required]
	public string Post { get; set; }
}