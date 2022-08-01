using System.ComponentModel.DataAnnotations;

namespace InviteApp.Models;

public class PartyInvitation
{
	[Required(ErrorMessage ="Please enter your name")]
	public string Name { get; init; }

	[Required(ErrorMessage = "Please enter your email address")]
	public string Email { get; init; }

	[Required(ErrorMessage = "Please enter your phone")]
	public string Phone { get; init; }

	[Required(ErrorMessage = "Please specify whether you will attend")]
	public bool? WillAttend { get; init; }
}
