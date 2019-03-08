using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public class AlbumRepository
    {
        AlbumContext db;
        public AlbumRepository(AlbumContext db)
        {
            this.db = db;
        }


        public Album GetByID(int id)
        {
            return db.Albums.Single(album => album.AlbumId == id);
        }

        public IEnumerable<Album> GetAll()
        {
            return db.Albums.ToList();
        }
    }
}
