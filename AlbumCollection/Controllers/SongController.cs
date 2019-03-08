using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Controllers
{
    public class SongController : Controller
    {
        SongRepository songRepo;
        public SongController(SongRepository songRepo)
        {
            this.songRepo = songRepo;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Song song)
        {
            songRepo.Create(song);
            return RedirectToAction("Index");
        }
    }
}
