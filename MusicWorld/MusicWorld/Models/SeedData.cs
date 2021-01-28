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
                        Title = "Hướng dương",
                        Artists = "Wowy",
                        Author = "Wowy",
                        UrlImage = "Huongduong.jpg",
                        Category = "Rap"
                    },
                    new Song
                    {
                        Title = "Bản giao hưởng định mệnh số 4",
                        Artists = "Beethoven",
                        Author = "Beethoven",
                        UrlImage = "baihat1.jpg",
                        Category = "Hòa Tấu Piano"

                    },
                    new Song
                    {
                        Title = "Bản giao hưởng định mệnh số 9",
                        Artists = "Beethoven",
                        Author = "Beethoven",
                        UrlImage = "baihat1.jpg",
                        Category = "Hòa Tấu Piano"
                    },
                    new Song
                    {
                        Title = "Bản giao hưởng định mệnh số 12",
                        Artists = "Beethoven",
                        Author = "Beethoven",
                        UrlImage = "baihat1.jpg",
                        Category = "Hòa Tấu Piano"
                    },
                    new Song
                    {
                        Title = "Symphone 5",
                        Artists = "Beethoven",
                        Author = "Beethoven",
                        UrlImage = "baihat1.jpg",
                        Category = "Hòa Tấu Piano"
                    },
                    new Song
                    {
                        Title = "Symphone No.40 In G Minor",
                        Artists = "Mozart",
                        Author = "Mozart",
                        UrlImage = "baihat2.jpg",
                        Category = "Giao Hưởng"
                    },
                    new Song
                    {
                        Title = "March Turkish",
                        Artists = "Mozart",
                        Author = "Mozart",
                        UrlImage = "baihat2.jpg",
                        Category = "Giao Hưởng"

                    },
                    new Song
                    {
                        Title = "Symphone No.40 In G Minor K 550",
                        Artists = "Mozart",
                        Author = "Mozart",
                        UrlImage = "baihat2.jpg",
                        Category = "Giao Hưởng"

                    },
                    new Song
                    {
                        Title = "The Legend of 1900 Playing Love",
                        Artists = "Yo Yo Ma",
                        Author = "Yo Yo Ma",
                        UrlImage = "baihat3.jpg",
                        Category = "Độc Tấu Hồ Cầm"

                    },
                    new Song
                    {
                        Title = "Sei Lod Und Preis Mit Ehren, BWV",
                        Artists = "Yo Yo Ma",
                        Author = "Yo Yo Ma",
                        UrlImage = "baihat3.jpg",
                        Category = "Độc Tấu Hồ Cầm"
                    },
                    new Song
                    {
                        Title = "Unaccompanied Cello Suite no.1",
                        Artists = "Yo Yo Ma",
                        Author = "Yo Yo Ma",
                        UrlImage = "baihat3.jpg",
                        Category = "Độc Tấu Hồ Cầm"
                    },
                    new Song
                    {
                        Title = "Marais: La Sonnerie De Sainte…..",
                        Artists = "Jacques Loussier trio",
                        Author = "Jacques Loussier trio",
                        UrlImage = "baihat4.jpg",
                        Category = "Hòa Tấu"
                    },
                    new Song
                    {
                        Title = "Handel: Sarabande And Variations",
                        Artists = "Jacques Loussier trio",
                        Author = "Jacques Loussier trio",
                        UrlImage = "baihat4.jpg",
                        Category = "Hòa Tấu"
                    },
                    new Song
                    {
                        Title = "Handel:Concerto In F Major Organ",
                        Artists = "Jacques Loussier trio",
                        Author = "Jacques Loussier trio",
                        UrlImage = "baihat4.jpg",
                        Category = "Hòa Tấu"
                    },
                    new Song
                    {
                        Title = "Chopin Barcarolle,op.60",
                        Artists = "Artur Rubinstein",
                        Author = "Artur Rubinstein",
                        UrlImage = "baihat5.jpg",
                        Category = "Hòa Tấu"
                    },
                    new Song
                    {
                        Title = "Spring(Concerto No.1 In E)",
                        Artists = "jean francois Paillard",
                        Author = "jean francois Paillard",
                        UrlImage = "baihat5.jpg",
                        Category = "Hòa Tấu"
                    },
                    new Song
                    {
                        Title = "Alicla De Larrocha",
                        Artists = "jean francois Paillard",
                        Author = "jean francois Paillard",
                        UrlImage = "baihat5.jpg",
                        Category = "Hòa Tấu"
                    });

            }
            if (!context.Artists.Any())
            {
                context.Artists.AddRange(
                    new Artists
                    {
                        Name = "Wowy",
                        Birthday = "27/9/1988",
                        Gender = "Nam",
                        Contact = "Wowy.com",
                        UrlImage = "Wowy.jpg"
                    },
                    new Artists
                    {
                        Name = "Trần Lập",
                        Birthday = "12/12/1974",
                        Gender = "Nam",
                        Contact = "tranlap.com",
                        UrlImage = "TranLap.jpg"
                    },
                    new Artists
                     {
                         Name = "Linkin Park",
                         Birthday = "1/1/1996",
                         Gender = "Nam",
                         Contact = "LinkkinPark.com",
                         UrlImage = "LinkinPark.jpg"
                     },
                    new Artists
                      {
                          Name = "Coldplay",
                          Birthday = "10/12/1996",
                          Gender = "Nam",
                          Contact = "coldplay.com",
                          UrlImage = "Coldplay.jpg"
                      },
                    new Artists
                       {
                           Name = "Ngọt",
                           Birthday = "1/1/2013",
                           Gender = "Nam",
                           Contact = "hoangvp102@gmail.com",
                           UrlImage = "Ngot.jpg"
                       },
                        new Artists
                        {
                            Name = "Imagine Dragons",
                            Birthday = "1/1/2012",
                            Gender = "Nam",
                            Contact = "imaginedragonsmusic.com",
                            UrlImage = "ImagineDragons.jpg"
                        },
                         new Artists
                         {
                             Name = "Hồ Trung Dũng",
                             Birthday = "12/1/1982",
                             Gender = "Nam",
                             Contact = "hotrungdung.com",
                             UrlImage = "Hotrungdung.jpg"
                         },
                          new Artists
                          {
                              Name = "Trần Mạnh Tuấn",
                              Birthday = "7/5/1970",
                              Gender = "Nam",
                              Contact = "tranmanhtuan.com",
                              UrlImage = "Tranmanhtuan.jpg"
                          },
                          new Artists
                          {
                              Name = "Michael Bublé",
                              Birthday = "9/9/1975",
                              Gender = "Nam",
                              Contact = "michaelbuble.com",
                              UrlImage = "MichaelBuble.jpg"
                          },
                          new Artists
                          {
                              Name = "Frank Sinatra",
                              Birthday = "12/12/1915",
                              Gender = "Nam",
                              Contact = "sinatra.com",
                              UrlImage = "FrankSinatra.jpg"
                          },
                          new Artists
                          {
                              Name = "Đức Tuấn",
                              Birthday = "2/6/1980",
                              Gender = "Nam",
                              Contact = "media.ductuan@gmail.com",
                              UrlImage = "Ductuan.jpg"
                          },
                          new Artists
                          {
                              Name = "Mr.siro",
                              Birthday = "2/6/1980",
                              Gender = "Nam",
                              Contact = "facebook.com/mrsiro.vuongquoctuan",
                              UrlImage = "mrsiro.jpg"
                          },
                          new Artists
                          {
                              Name = "Trung Quân",
                              Birthday = "20/1/1989",
                              Gender = "Nam",
                              Contact = "soundcloud.com/quancartoon",
                              UrlImage = "trungquan.jpg"
                          },
                          new Artists
                          {
                              Name = "Bích Phương",
                              Birthday = "  30/9/1989",
                              Gender = "Nữ",
                              Contact = "contact@1989s.vn",
                              UrlImage = "bichphuong.jpg"
                          },
                    new Artists
                          {
                              Name = "Soobin Hoàng Sơn",
                              Birthday = "10/9/1992",
                              Gender = "Nam",
                              Contact = "soobin.vn",
                              UrlImage = "soobinhoangson.jpg"
                          },
                    new Artists
                          {
                              Name = "Đức Phúc",
                              Birthday = " 15/10/1996",
                              Gender = "Nam",
                              Contact = "ducphucofficial@gmail.com",
                              UrlImage = "ducphuc.jpg"
                          },
                    new Artists
                          {
                              Name = "Ludwig van Beethoven",
                              Birthday = "17/12/1770-26/3/1827",
                              Gender = "Nam",
                              UrlImage = "Beethoven.jpg"
                          },
                    new Artists
                    {
                        Name = "Mozart",
                        Birthday = "27/1/1756",
                        Gender = "Nam",
                        UrlImage = "mozart.jpg"
                    },
                    new Artists
                    {
                        Name = "Yo Yo Ma",
                        Birthday = "7/10/1955",
                        Gender = "Nam",
                        UrlImage = "yoma.jpg"
                    },
                    new Artists
                    {
                        Name = "Jacques Loussier Trio",
                        Birthday = "26/10/1934",
                        Gender = "Nam",
                        UrlImage = "trio.jpg.jpg"
                    },
                    new Artists
                    {
                        Name = "Artur Rubinstein",
                        Birthday = "28/1/1887",
                        Gender = "Nam",
                        UrlImage = "rubinstein.jpg"
                    },
                    new Artists
                    {
                        Name = "Jean Francois Paillard",
                        Birthday = "12/4/1928",
                        Gender = "Nam",
                        UrlImage = "paillard.jpg"
                    },
                    new Artists
                    {
                        Name = "Alicia De Larrocha",
                        Birthday = "23/5/1923",
                        Gender = "Nữ",
                        UrlImage = "larrocha.jpg"
                    });
            }
            context.SaveChanges();
        }
        
    }
   
}
