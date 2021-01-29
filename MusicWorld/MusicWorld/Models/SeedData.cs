using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            var events = new Event[]
            {
                new Event
                {
                    Title = "Đại Nhạc Hội REALME",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "HN",
                    StartingDate = "3/10/2019",
                     UrlImage = "sk_1.jpg"

                },
                new Event
                {
                    Title = "CountDown",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Nha Trang",
                    StartingDate = "3/10/2019",
                     UrlImage = "sk_2.jpg"

                }
            };
            foreach (Event e in events)
            {
                context.Events.Add(e);
            }
            context.SaveChanges();

            var artists = new Artists[]
               {
                        new Artists
                        {
                                Name = "Michael Jackson",
                                Birthday = "29/8/1958",
                                Gender = "Nam",
                                Contact = "Michael Jackson.com",
                                UrlImage = "MichaelJackson.jpg",
                                 EventId = events.Single(e=> e.Title == "CountDown").Id
                            
                        },
                        new Artists
                        {
                            Name = "Whitney Houston",
                                Birthday = "9/8/1963",
                                Gender = "Nữ",
                                Contact = "WhitneyHouston.com",
                                UrlImage = "WhitneyHouston.jpg",
                                EventId = events.Single(e=> e.Title == "Đại Nhạc Hội REALME").Id
                        }
                };

            foreach (Artists a in artists)
            {
                context.Artists.Add(a);
            }
            context.SaveChanges();

            var albums = new Album[]
            {
                new Album
                {
                    Title ="Top HITS của năm",
                    Description = "Những bài hát hay tiêu biểu hay nhất được zingmp3 tuyển chọn",
                    ReleaseDate = "5/1/2020",
                    UrlImage = "album5.jpg"
                },
                 new Album
                {
                    Title ="Những bài hát được nghe nhiều",
                    Description = "Những bài hát hay tiêu biểu hay nhất được zingmp3 tuyển chọn",
                    ReleaseDate = "5/1/2020",
                    UrlImage = "album4.jpg"
                },
            };
            foreach (Album a in albums)
            {
                context.Albums.Add(a);
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
                        ArtistsId = artists.Single(a => a.Name == "Whitney Houston").Id,
                        AlbumsId = albums.Single(a => a.Title == "Những bài hát được nghe nhiều").Id
                         
                },
                new Song
                {
                        Title = "Girlfriend",

                        Author = "Michael Jackson",
                        UrlImage = "OffTheWall.jpg",
                        Category = "Pop",
                        ArtistsId = artists.Single(a => a.Name == "Michael Jackson").Id,
                       AlbumsId = albums.Single(a => a.Title == "Top HITS của năm").Id
                },
                 new Song
                {
                        Title = "I Can Help It",
                        Author = "Michael Jackson",
                        UrlImage = "OffTheWall.jpg",
                        Category = "Pop",
                        ArtistsId = artists.Single(a => a.Name == "Michael Jackson").Id,
                       AlbumsId = albums.Single(a => a.Title == "Top HITS của năm").Id
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
