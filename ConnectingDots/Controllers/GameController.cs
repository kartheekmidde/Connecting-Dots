using ConnectingDots.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CarFinalProject1.Controllers
{
    public class GameController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize(Roles = "Parent")]
        public ActionResult Index()
        {
            List<Game> allGames = db.Games.ToList();

            GameViewModel viewModel = new GameViewModel
            {
                Game = new Game(),
                AllGames = allGames
            };

            return View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "Parent")]
        public ActionResult Create(Game game)
        {
            if (ModelState.IsValid)
            {
                int instChildAvailable = db.Games
                                       .Where(p => p.child == game.child)
                                       .Count();
                if (instChildAvailable > 0)
                {
                    var messages = "Child name already exists.";
                    Response.StatusCode = 403;
                    return Content(string.Join("\n", messages), "text/html");
                } else
                {
                    db.Games.Add(game);
                    db.SaveChanges();
                    return PartialView("_gameCreate", game);
                }
            }
            else
            {
                var errors = ModelState.Where(x => x.Value.Errors.Any()).Select(x => x.Value.Errors);
                var messages = errors.SelectMany(x => x).Select(x => x.ErrorMessage);
                Response.StatusCode = 403;
                return Content(string.Join("\n", messages), "text/html");
            }
        }

        [HttpPost]
        [Authorize(Roles = "Parent")]
        public ActionResult Delete(int id)
        {
            Game game = new Game { Id = id };
            db.Entry(game).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Content(id.ToString());
        }

        [Authorize(Roles = "Child")]
        public ActionResult Play()
        {
            List<Game> allGames = db.Games.Where(x => x.child == User.Identity.Name).ToList();

            GameViewModel viewModel = new GameViewModel
            {
                Game = new Game(),
                AllGames = allGames
            };

            return View(viewModel);
        }

        [Authorize]
        public ActionResult updateStop(int Id, string stop)
        {

            if (Request.IsAjaxRequest())
            {
                Game game = db.Games.Find(Id);
                if (stop == "1")
                {
                    @game.stop1_stat = "Found";
                    db.Games.Attach(game);
                    db.Entry(game).Property(x => x.stop1_add).IsModified = true;
                }
                if (stop == "2")
                {
                    @game.stop2_stat = "Found";
                    db.Games.Attach(game);
                    db.Entry(game).Property(x => x.stop2_add).IsModified = true;
                }
                if (stop == "3")
                {
                    @game.stop3_stat = "Found";
                    db.Games.Attach(game);
                    db.Entry(game).Property(x => x.stop3_add).IsModified = true;
                }
                if (stop == "4")
                {
                    @game.stop4_stat = "Found";
                    db.Games.Attach(game);
                    db.Entry(game).Property(x => x.stop4_add).IsModified = true;
                }
                if (stop == "5")
                {
                    @game.stop5_stat = "Found";
                    db.Games.Attach(game);
                    db.Entry(game).Property(x => x.stop5_add).IsModified = true;
                }
                if (stop == "6")
                {
                    @game.stop6_stat = "Found";
                    db.Games.Attach(game);
                    db.Entry(game).Property(x => x.stop6_add).IsModified = true;
                }


                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
                return Json(game, JsonRequestBehavior.AllowGet);
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
    }
}
