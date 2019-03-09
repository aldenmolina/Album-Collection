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
            int expectedId = 2;
            var songRepo = new SongRepository(null);
            var underTest = new SongController(songRepo);

            var result = underTest.Create(expectedId);

            Assert.IsType<ViewResult>(result);

        }
    }
}
