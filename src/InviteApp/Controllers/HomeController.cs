using InviteApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace InviteApp.Controllers;

public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger)
	{
		_logger = logger;
	}

	[HttpGet]
	public IActionResult Index()
	{
		var hour = DateTime.Now.Hour;
		var greeting = hour < 12 ? "Good morning!" : "Good evening!";
		ViewBag.Greeting = greeting;
		return View();
	}

	[HttpGet]
	public ViewResult RsvpForm()
	{
		return View();
	}

	[HttpPost]
	public ViewResult RsvpForm(PartyInvitation partyInvitation)
	{
		if(!ModelState.IsValid) return View();

		Repository.AddReponse(partyInvitation);
		return View("Thanks", partyInvitation);
	}

	[HttpGet]
	public ViewResult ListResponses() => View(Repository.PartyInvitions.Where(x => x.WillAttend == true));
}
