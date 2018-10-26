using BlackJackGame.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MVCBlackJackGame.Controllers {
    public class HomeController : Controller {
        private BlackJack _blackJack;
        public IActionResult Index() {
            _blackJack = new BlackJack();
            HttpContext.Session.SetString("BlackJack", JsonConvert.SerializeObject(_blackJack));
            return View(_blackJack);
        }

      
    }
}