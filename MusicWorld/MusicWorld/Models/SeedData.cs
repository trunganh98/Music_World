using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicWorld.Models;

namespace MusicWorld.Models
{
    public class SeedData
    {
        public static void EnsurePopulate(IApplicationBuilder app)
        {
            MusicDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MusicDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (context.Artists.Any())
            {
                return;
            }
                var artists = new Artists[]
                   {
                        new Artists
                        {
                                Name = "Michael Jackson",
                                Birthday = "29/8/1958",
                                Gender = "Nam",
                                Contact = "Michael Jackson.com",
                                UrlImage = "MichaelJackson.jpg"
                        },
                        new Artists
                        {
                            Name = "Whitney Houston",
                                Birthday = "9/8/1963",
                                Gender = "Nữ",
                                Contact = "WhitneyHouston.com",
                                UrlImage = "WhitneyHouston.jpg"
                        }
                    };
            
            foreach (Artists a in artists)
            {
                context.Artists.Add(a);
            }
            context.SaveChanges();

            var songs = new Song[]
            {
                new Song
                {
                        Title = "Get On The Floor",
                        Author = "Michael Jackson",
                        UrlImage = "OffTheWall.jpg",
                        Category = "Pop",
                        ArtistsId = artists.Single(a => a.Name == "Whitney Houston").Id
                },
                new Song
                {
                        Title = "Girlfriend",
                  
                        Author = "Michael Jackson",
                        UrlImage = "OffTheWall.jpg",
                        Category = "Pop",
                        ArtistsId = artists.Single(a => a.Name == "Michael Jackson").Id
                },
                 new Song
                {
                        Title = "I Can Help It",
                        Author = "Michael Jackson",
                        UrlImage = "OffTheWall.jpg",
                        Category = "Pop",
                        ArtistsId = artists.Single(a => a.Name == "Michael Jackson").Id
                }

            };

            foreach (Song s in songs)
            {
                context.Songs.Add(s);
            }
            context.SaveChanges();
        }

    }

}
