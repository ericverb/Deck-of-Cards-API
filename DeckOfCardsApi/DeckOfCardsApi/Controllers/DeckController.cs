using Microsoft.AspNetCore.Mvc;
using DeckOfCardsApi.Models;
using Flurl.Http;

namespace DeckOfCardsApi.Controllers
{
    public class DeckController : Controller
    {
        public IActionResult Index()
        {
            string apiUri = "https://deckofcardsapi.com/api/deck/new/";
            var apiTask = apiUri.GetJsonAsync<NewDeckApi>();
            apiTask.Wait();
            NewDeckApi deck = apiTask.Result;
            return View(deck);

        }

        public IActionResult DrawFive()
        {
            string apiUriDeck = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            var apiTaskDeck = apiUriDeck.GetJsonAsync<NewDeckApi>();
            apiTaskDeck.Wait();
            NewDeckApi deck = apiTaskDeck.Result;
            

            string apiUri = $"https://deckofcardsapi.com/api/deck/{deck.deck_id}/draw/?count=5";
            var apiTask = apiUri.GetJsonAsync<DrawFive>();
            apiTask.Wait(); 
            DrawFive cards = apiTask.Result;
            return View(cards.cards);

        }
    }
}
