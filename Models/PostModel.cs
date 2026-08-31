public class PostModel
{
	[Required]
	[StringLength(1000, ErrorMessage = "Post exceeds the 400 character limit.")]
	public string Post { get; set; }
	[EmailAdress]
	public string Email { get; set; }
}