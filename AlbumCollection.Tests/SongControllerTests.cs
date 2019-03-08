using AlbumCollection.Controllers;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlbumCollection.Tests
{
    public class SongControllerTests
    {
        [Fact]
        public void Can_Create_Song()
        {
            var songRepo = new SongRepository(null);
            var underTest = new SongController(songRepo);

            var result = underTest.Create();

            Assert.IsType<ViewResult>(result);

        }
    }
}
