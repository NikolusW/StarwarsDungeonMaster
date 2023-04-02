using Hackathon_Project2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using System.Linq.Expressions;
using Hackathon_Project2.Services;


namespace Hackathon_Project2.Controllers
{
    public class SceneController : Controller
    {

        private readonly IChatGPTApiService _chatGPTApiService;

        public SceneController(IChatGPTApiService chatGPTAPIService)
        {
            _chatGPTApiService = chatGPTAPIService;
        }


        // after recieving the film info we need to send that info to the 
        // GET: SceneSelection
        [ActionName("Scene_Selection")]
        public async Task<ActionResult> Index()
        {

            // currently selecting the option value
            //string sf= 
            string character = Request.Form["Character"];
            string film = Request.Form["Film"];
            var film2 = new FilmModel()
            {
                Title = film
            };
            var character2 = new PlayerModel()
            {
                Name = character
            };
            /*
            var model = new SelectionViewModelcs()
            {
              
                FilmModel = film2,
                PlayerModel = character2

            };
            */
            
            string query = "You are a Dungeon Master for a star wars themed Dungeons and Dragons like game. You will describe a scenario and allow the player to respond with what they want to do, " +
                "and you will ask them to roll when needed, and tell the player when a roll is expected." +
                "The player is " + character + " and it should take place in the movie " + film + ". Only respond as the DM, allow me to respond as the player. Do not speak for the players and keep" +
                "your responses limited to 4 sentences.";
            
            string message = await _chatGPTApiService.UseChatGPT(query);

            var model = new MessageModel()
            {
                Message = message
            };

            return View("Scene_Selection", model);
        }


        [ActionName("Conversation")]

        public async Task<ActionResult> Conversation()
        {
            string query = Request.Form["userresponse"];
            
            string message = await _chatGPTApiService.UseChatGPT(query);

            var model = new MessageModel()
            {
                Message = message
            };

            return View("Scene_Selection", model);
        }
    }
}
