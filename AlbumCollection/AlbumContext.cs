using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=AldenAlbums;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(

                new Album()
                {
                    AlbumId = 1,
                    Name = "Juturna",
                    ArtistName = "Circa Survive",
                    ImgPath = "/Images/Juturna.jpg"
                },

                new Album()
                {
                    AlbumId = 2,
                    Name = "Downtown Battle Mountain II",
                    ArtistName = "Dance Gavin Dance",
                    ImgPath = "/Images/DowntownBattleMountain2.jpg"
                },

                new Album()
                {
                    AlbumId = 3,
                    Name = "Love Scars 3",
                    ArtistName = "Trippie Redd",
                    ImgPath = "/Images/LoveScars3.png"
                });

            modelBuilder.Entity<Song>().HasData(

                new Song()
                {
                    SongId = 1,
                    AlbumId = 1,
                    Name = "Wish Resign",
                    RunTime = "4:14"
                },

                new Song()
                {
                    SongId = 2,
                    AlbumId = 1,
                    Name = "In Fear and Faith",
                    RunTime = "3:35"
                },

                new Song()
                {
                    SongId = 3,
                    AlbumId = 1,
                    Name = "Stop the Fuckin' Car",
                    RunTime = "4:22"
                },

                new Song()
                {
                    SongId = 4,
                    AlbumId = 1,
                    Name = "We're All Thieves",
                    RunTime = "4:53"
                },

                new Song()
                {
                    SongId = 5,
                    AlbumId = 2,
                    Name = "Perfect",
                    RunTime = "2:59"
                },

                new Song()
                {
                    SongId = 6,
                    AlbumId = 2,
                    Name = "Heat Seeking Ghost of Sex",
                    RunTime = "4:07"
                },

                new Song()
                {
                    SongId = 7,
                    AlbumId = 2,
                    Name = "Spooks",
                    RunTime = "4:04"
                },

                new Song()
                {
                    SongId = 8,
                    AlbumId = 2,
                    Name = "Blue Dream",
                    RunTime = "4:41"
                },

                new Song()
                {
                    SongId = 9,
                    AlbumId = 3,
                    Name = "Camp Fire Tale",
                    RunTime = "2:29"
                },

                new Song()
                {
                    SongId = 10,
                    AlbumId = 3,
                    Name = "Toxic Waste",
                    RunTime = "2:53"
                },

                new Song()
                {
                    SongId = 11,
                    AlbumId = 3,
                    Name = "Fire Starter",
                    RunTime = "2:37"
                },

                new Song()
                {
                    SongId = 12,
                    AlbumId = 3,
                    Name = "Can't Love",
                    RunTime = "2:49"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
