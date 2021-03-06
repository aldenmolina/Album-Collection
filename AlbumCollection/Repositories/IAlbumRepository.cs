﻿using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAll();
        Album GetByID(int id);
        void Create(Album album);
    }
}
