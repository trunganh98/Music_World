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
                //Ballad
                new Event {
                  Title = "Đại Nhạc Hội REALME",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "HN",
                    StartingDate = "3/10/2019",
                    UrlImage = "sk_1.jpg"

                },
                new Event {
                  Title = "CountDown",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Nha Trang",
                    StartingDate = "3/10/2019",
                    UrlImage = "sk_2.jpg"

                },
                new Event {
                  Title = "Đại Nhạc Hội TP.BANK",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Ha Noi",
                    StartingDate = "2/02/2021",
                    UrlImage = "sk_3.jpg"
                },
                new Event {
                  Title = "Music Awards",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Hong Khong",
                    StartingDate = "5/12/2021",
                    UrlImage = "sk_4.jpg"
                },
                new Event {
                  Title = "Dạ khúc cho tình nhân",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Ha Noi",
                    StartingDate = "29/12/2020",
                    UrlImage = "sk_5.jpg"
                }
            };
            foreach (Event e in events)
            {
                context.Events.Add(e);
            }
            context.SaveChanges();

            var artists = new Artists[]
               {
                        new Artists {
                          Name = "Hồ Trung Dũng",
                            Birthday = "12/1/1982",
                            Gender = "Nam",
                            Contact = "hotrungdung.com",
                            UrlImage = "Hotrungdung.jpg",
                            EventId = events.Single(e => e.Title == "CountDown").Id
                        },
                        new Artists {
                          Name = "Trần Mạnh Tuấn",
                            Birthday = "7/5/1970",
                            Gender = "Nam",
                            Contact = "tranmanhtuan.com",
                            UrlImage = "Tranmanhtuan.jpg",
                            EventId = events.Single(e => e.Title == "CountDown").Id
                        },
                        new Artists {
                          Name = "Imagine Dragons",
                            Birthday = "1/1/2012",
                            Gender = "Nam",
                            Contact = "imaginedragonsmusic.com",
                            UrlImage = "ImagineDragons.jpg",
                            EventId = events.Single(e => e.Title == "Đại Nhạc Hội REALME").Id
                        },
                        new Artists {
                          Name = "Đức Tuấn",
                            Birthday = "2/6/1980",
                            Gender = "Nam",
                            Contact = "media.ductuan@gmail.com",
                            UrlImage = "Ductuan.jpg",
                            EventId = events.Single(e => e.Title == "Đại Nhạc Hội REALME").Id
                        },
                        new Artists {

                          Name = "Trần Lập",
                            Birthday = "12/12/1974",
                            Gender = "Nam",
                            Contact = "tranlap.com",
                            UrlImage = "TranLap.jpg",
                            EventId = events.Single(e => e.Title == "Đại Nhạc Hội TP.BANK").Id
                        },
                        new Artists {

                          Name = "Ngọt",
                            Birthday = "1/1/2013",
                            Gender = "Nam",
                            Contact = "hoangvp102@gmail.com",
                            UrlImage = "Ngot.jpg",
                            EventId = events.Single(e => e.Title == "Đại Nhạc Hội TP.BANK").Id
                        },
                        new Artists {

                          Name = "Mr.siro",
                            Birthday = " 18/11/1982",
                            Gender = "Nam",
                            Contact = "facebook.com/mrsiro.vuongquoctuan",
                            UrlImage = "mrsiro.jpg",
                            EventId = events.Single(e => e.Title == "Music Awards").Id
                        },
                        new Artists {

                          Name = "Trung Quân",
                            Birthday = "20/1/1989",
                            Gender = "Nam",
                            Contact = "soundcloud.com/quancartoon",
                            UrlImage = "trungquan.jpg",
                            EventId = events.Single(e => e.Title == "Music Awards").Id
                        },
                        new Artists {
                          Name = "Bích Phương",
                            Birthday = "30/9/1989",
                            Gender = "Nữ",
                            Contact = "contact@1989s.vn",
                            UrlImage = "bichphuong.jpg",
                            EventId = events.Single(e => e.Title == "Dạ khúc cho tình nhân").Id
                        },
                        new Artists {
                          Name = "Soobin Hoàng Sơn",
                            Birthday = "10/9/1992",
                            Gender = "Nữ",
                            Contact = "soobin.vn",
                            UrlImage = "soobinhoangson.jpg",
                            EventId = events.Single(e => e.Title == "Dạ khúc cho tình nhân").Id
                        }
                };

            foreach (Artists a in artists)
            {
                context.Artists.Add(a);
            }
            context.SaveChanges();

            var albums = new Album[]
            {
                new Album {
                  Title = "Top HITS của năm",
                    Description = "Những bài hát hay tiêu biểu hay nhất được zingmp3 tuyển chọn",
                    ReleaseDate = "5/1/2020",
                    UrlImage = "album5.jpg"
                },
                new Album {
                  Title = "Những bài hát được nghe nhiều",
                    Description = "Những bài hát hay tiêu biểu hay nhất được zingmp3 tuyển chọn",
                    ReleaseDate = "5/1/2020",
                    UrlImage = "album4.jpg"
                },
                new Album {
                  Title = "Những bản nhạc jazz hay nhất",
                    Description = "Tuyển tập 10 bản nhạc Jazz do Zing MP3 chọn lựa. Cùng thư giãn với Playlist này nhé! ",
                    ReleaseDate = "3/1/2020",
                    UrlImage = "album3.jpg"
                },
                new Album {
                  Title = "Chặng Đường Rock Việt",
                    Description = "Lời tựa Nhìn lại một chặng đường của Rock Việt với chất Rock đầy sáng tạo và gai góc của Bức Tường, Microwave... đến những nhân tố mới đầy triển vọng như Bụi Gió, Cá Hồi Hoang…",
                    ReleaseDate = "2/1/2020",
                    UrlImage = "album2.jpg"
                },
                new Album {
                  Title = "Những bản nhạc việt hiện đại",
                    Description = "Những bản nhạc mới mang hướng mới lạ trong nước và hướng tới cả khán giả quốc tế..",
                    ReleaseDate = "1/1/2020",
                    UrlImage = "album_1.jpg"
                }
            };
            foreach (Album a in albums)
            {
                context.Albums.Add(a);
            }
            context.SaveChanges();

            var songs = new Song[]
            {
                new Song {
                  Title = "Một Bước Yêu Vạn Dặm Đau",
                    Author = "Mr.siro",
                    UrlImage = "mrsiro_1.jpg",
                    Category = "Balland",
                    ArtistsId = artists.Single(a => a.Name == "Mr.siro").Id,
                    AlbumsId = albums.Single(a => a.Title == "Top HITS của năm").Id

                },
                new Song {
                  Title = "Lắng Nghe Nước Mắt",
                    Author = "Mr.siro",
                    UrlImage = "mrsiro_2.jpg",
                    Category = "Balland",
                    ArtistsId = artists.Single(a => a.Name == "Mr.siro").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bản nhạc việt hiện đại").Id

                },
                new Song {
                  Title = "Chiều nay không có mưa bay",
                    Author = "Trung Quân",
                    UrlImage = "trungquan_1.jpg",
                    Category = "Balland",
                    ArtistsId = artists.Single(a => a.Name == "Trung Quân").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bài hát được nghe nhiều").Id
                },
                new Song {
                  Title = "Dấu Mưa",
                    Author = "Trung Quân",
                    UrlImage = "trungquan_2.jpg",
                    Category = "Balland",
                    ArtistsId = artists.Single(a => a.Name == "Trung Quân").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bài hát được nghe nhiều").Id
                },
                new Song {
                  Title = "Bèo dạt mây trôi",
                    Author = "Trần Mạnh Tuấn",
                    UrlImage = "Tranmanhtuan_1.jpg",
                    Category = "Jazz",
                    ArtistsId = artists.Single(a => a.Name == "Trần Mạnh Tuấn").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bản nhạc jazz hay nhất").Id
                },
                new Song {
                  Title = "Quê Hương",
                    Author = "Trần Mạnh Tuấn",
                    UrlImage = "Tranmanhtuan_2.jpg",
                    Category = "Jazz",
                    ArtistsId = artists.Single(a => a.Name == "Trần Mạnh Tuấn").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bản nhạc jazz hay nhất").Id
                },
                new Song {
                  Title = "Đường Đến Vinh Quang",
                    Author = "Trần Lập",
                    UrlImage = "TranLap_1.jpg",
                    Category = "Rock",
                    ArtistsId = artists.Single(a => a.Name == "Trần Lập").Id,
                    AlbumsId = albums.Single(a => a.Title == "Chặng Đường Rock Việt").Id
                },
                new Song {
                  Title = "Tâm Hồn Của Đá ",
                    Author = "Trần Lập",
                    UrlImage = "TranLap_2.jpg",
                    Category = "Rock",
                    ArtistsId = artists.Single(a => a.Name == "Trần Lập").Id,
                    AlbumsId = albums.Single(a => a.Title == "Chặng Đường Rock Việt").Id
                },
                new Song {
                  Title = "Bao giờ lấy chồng",
                    Author = "Bích Phương",
                    UrlImage = "bichphuong_3.jpg",
                    Category = "Balland",
                    ArtistsId = artists.Single(a => a.Name == "Bích Phương").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bản nhạc việt hiện đại").Id
                },
                new Song {
                  Title = "Em bỏ hút thuốc chưa",
                    Author = "Bích Phương",
                    UrlImage = "bichphuong_5.jpg",
                    Category = "Balland",
                    ArtistsId = artists.Single(a => a.Name == "Bích Phương").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bản nhạc việt hiện đại").Id
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
