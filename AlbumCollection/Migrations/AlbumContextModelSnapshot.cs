﻿// <auto-generated />
using AlbumCollection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumCollection.Migrations
{
    [DbContext(typeof(AlbumContext))]
    partial class AlbumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumCollection.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistName");

                    b.Property<string>("ImgPath");

                    b.Property<string>("Name");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { AlbumId = 1, ArtistName = "Circa Survive", ImgPath = "/Images/Juturna.jpg", Name = "Juturna" },
                        new { AlbumId = 2, ArtistName = "Dance Gavin Dance", ImgPath = "/Images/DowntownBattleMountain2.jpg", Name = "Downtown Battle Mountain II" },
                        new { AlbumId = 3, ArtistName = "Trippie Redd", ImgPath = "/Images/LoveScars3.png", Name = "Love Scars 3" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("Name");

                    b.Property<string>("RunTime");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { SongId = 1, AlbumId = 1, Name = "Wish Resign", RunTime = "4:14" },
                        new { SongId = 2, AlbumId = 1, Name = "In Fear and Faith", RunTime = "3:35" },
                        new { SongId = 3, AlbumId = 1, Name = "Stop the Fuckin' Car", RunTime = "4:22" },
                        new { SongId = 4, AlbumId = 1, Name = "We're All Thieves", RunTime = "4:53" },
                        new { SongId = 5, AlbumId = 2, Name = "Perfect", RunTime = "2:59" },
                        new { SongId = 6, AlbumId = 2, Name = "Heat Seeking Ghost of Sex", RunTime = "4:07" },
                        new { SongId = 7, AlbumId = 2, Name = "Spooks", RunTime = "4:04" },
                        new { SongId = 8, AlbumId = 2, Name = "Blue Dream", RunTime = "4:41" },
                        new { SongId = 9, AlbumId = 3, Name = "Camp Fire Tale", RunTime = "2:29" },
                        new { SongId = 10, AlbumId = 3, Name = "Toxic Waste", RunTime = "2:53" },
                        new { SongId = 11, AlbumId = 3, Name = "Fire Starter", RunTime = "2:37" },
                        new { SongId = 12, AlbumId = 3, Name = "Can't Love", RunTime = "2:49" },
                        new { SongId = 13, AlbumId = 1, Name = "The Glorious Nosebleed", RunTime = "3:12" },
                        new { SongId = 14, AlbumId = 1, Name = "Meet Me in Montauk", RunTime = "14:39" },
                        new { SongId = 15, AlbumId = 2, Name = "Swan Soup", RunTime = "4:01" },
                        new { SongId = 16, AlbumId = 2, Name = "Pounce Bounce", RunTime = "2:26" },
                        new { SongId = 17, AlbumId = 3, Name = "Topanga", RunTime = "3:35" },
                        new { SongId = 18, AlbumId = 3, Name = "Love Scars 3", RunTime = "2:09" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.HasOne("AlbumCollection.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
