using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() //MadLibs
    {
      return View();
    }

    // [Route("/")]
    // public ActionResult Form() 
    // { 
    //   return View(); 
    // }

    [Route("/finishedMadLib")]
    public ActionResult FinishedMadLib(string noun, string verb, string adjective)
    {
      Game newGame = new Game();
      newGame.Noun = noun;
      newGame.Verb = verb;
      newGame.Adjective = adjective;
      return View(newGame);
    }
  }
}