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
                    Name = "On Letting Go",
                    ArtistName = "Circa Survive",
                    ImgPath = "/Images/OnLettingGo.jpg"
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
                    ImgPath = "/Images/LoveScars3"
                }
                
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
