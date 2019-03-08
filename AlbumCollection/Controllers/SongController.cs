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
        ISongRepository songRepo;

        public SongController(ISongRepository albumRepo)
        {
            this.songRepo = albumRepo;
        }

        public ViewResult Index()
        {
            var model = songRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = songRepo.GetByID(id);
            return View(model);
        }
    }
}
