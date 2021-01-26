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
            if (!context.Songs.Any())
            {
                context.Songs.AddRange(
                    new Song
                    {
                        Title = "",
                        Artists = "",
                        Author = "",
                        UrlImage = ""
                    });

            }
            if (!context.Artists.Any())
            {
                context.Artists.AddRange(
                    new Artists
                    {
                        Name = "",
                        Birthday = "",
                        Gender = "",
                        Contact = "",
                        UrlImage = ""
                    });
            }
            if (!context.Albums.Any())
            {
                context.Albums.AddRange(
                    new Album
                    {
                        Title = "",
                        Description = "",
                        Artists = "",
                        Place = "",
                        StartingDate = "",
                        UrlImage = ""
                    });
            }
            if (!context.Events.Any())
            {
                context.Events.AddRange(
                    new Event
                    {
                        Title = "",
                        Description = "",
                        Artists = "",
                        TicketPrice = "",
                        Place = "",
                        StartingDate = "",
                        UrlImage = ""
                    });
            }
        }
    }
   
}
