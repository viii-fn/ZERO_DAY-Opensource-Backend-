using System.ComponentModel.DataAnnotations;

public class PostModel
{
	int Id { get; set; }
	[Required]
	[StringMaxLength(1000, ErrorMessage = "Post cannot be more than a thousand characters.")]
	[StringMinLength(1, ErrorMessage = "Post to small")]
	public string Post { get; set; }
}