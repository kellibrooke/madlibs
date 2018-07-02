using Microsoft.AspNetCore.Mvc;
using MadLips.Models;

namespace MadLips.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("/story")]
        public ActionResult Story()
        {
            Vocabulary newVocabulary = new Vocabulary();
            newVocabulary.SetAdj1(Request.Query["adj1"]);
            newVocabulary.SetAdj2(Request.Query["adj2"]);
            newVocabulary.SetAdj3(Request.Query["adj3"]);
            newVocabulary.SetNoun1(Request.Query["noun1"]);
            newVocabulary.SetNoun2(Request.Query["noun2"]);
            newVocabulary.SetNoun3(Request.Query["noun3"]);
            newVocabulary.SetPNoun1(Request.Query["p-noun1"]);
            newVocabulary.SetPNoun2(Request.Query["p-noun2"]);
            newVocabulary.SetPNoun3(Request.Query["p-noun3"]);
            newVocabulary.SetPNoun4(Request.Query["p-noun4"]);
            newVocabulary.SetGame(Request.Query["game"]);
            newVocabulary.SetVerbIng1(Request.Query["ing-verb1"]);
            newVocabulary.SetVerbIng2(Request.Query["ing-verb2"]);
            newVocabulary.SetVerbIng3(Request.Query["ing-verb3"]);
            newVocabulary.SetVerbIng4(Request.Query["ing-verb4"]);
            newVocabulary.SetPlant(Request.Query["plant"]);
            newVocabulary.SetBodyPart(Request.Query["body-part"]);
            newVocabulary.SetPlace(Request.Query["place"]);
            newVocabulary.SetNumber(Request.Query["number"]);
            return View(newVocabulary);
        }
    }
}
