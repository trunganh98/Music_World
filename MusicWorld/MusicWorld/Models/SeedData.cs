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
                        Title = "Đường Đến Vinh Quang",
                        Artists = "Trần Lập",
                        Author = "Bức Tường",
                        UrlImage = "TranLap_1.jpg",
                        Category = "Rock"
                        
                    });

            }
            if (!context.Artists.Any())
            {
                context.Artists.AddRange(
                    new Artists
                    {
                        Name = "Trần Lập",
                        Birthday = "12/12/1974",
                        Gender = "Nam",
                        Contact = "tranlap.com",
                        UrlImage = "TranLap.jpg"
                    });
            }
            context.SaveChanges();
        }
        
    }
   
}
