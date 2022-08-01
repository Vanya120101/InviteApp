using System.Collections.Generic;

namespace InviteApp.Models;

public static class Repository
{
	private static readonly List<PartyInvitation> _invites = new();

	public static IEnumerable<PartyInvitation> PartyInvitions=> _invites;

	public static void AddReponse(PartyInvitation partyInvitation) => _invites.Add(partyInvitation);
}
