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
                    },
                    new Song
                    {
                        Title = "Baby Be Mine",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "Thriller.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Beat It",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "Thriller.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Human Nature",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "Thriller.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Wanna Be Startin Somethin",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "Thriller.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "The Lady In My Life",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "Thriller.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Off The Wall",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "Thriller.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Off The Wall",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "OffTheWall.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "I Can Help It",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "OffTheWall.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Get On The Floor",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "OffTheWall.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Girlfriend",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "OffTheWall.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Rock With You",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "OffTheWall.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Bad",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "Bad.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Speed Demon",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "Bad.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Just Good Friends",
                        Artists = "Michael Jackson",
                        Author = "Michael Jackson",
                        UrlImage = "Bad.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Saving All My Love For You",
                        Artists = "Whitney Houston",
                        Author = "Whitney Houston",
                        UrlImage = "AlbumWhitney Houston.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "How Will I Know",
                        Artists = "Whitney Houston",
                        Author = "Whitney Houston",
                        UrlImage = "AlbumWhitney Houston.jpg",
                        Category = "Pop"

                    });
                context.Songs.AddRange(
                    new Song
                    {
                        Title = "All At Oonce",
                        Artists = "Whitney Houston",
                        Author = "Whitney Houston",
                        UrlImage = "AlbumWhitney Houston.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Where Are You",
                        Artists = "Whitney Houston",
                        Author = "Whitney Houston",
                        UrlImage = "Whitney.jpg",
                        Category = "Pop"

                    },
                     new Song
                     {
                         Title = "Love It a Contact Sport",
                         Artists = "Whitney Houston",
                         Author = "Whitney Houston",
                         UrlImage = "Whitney.jpg",
                         Category = "Pop"

                     },
                    new Song
                    {
                        Title = "You're Still My Man",
                        Artists = "Whitney Houston",
                        Author = "Whitney Houston",
                        UrlImage = "Whitney.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "For The Love Of You",
                        Artists = "Whitney Houston",
                        Author = "Whitney Houston",
                        UrlImage = "Whitney.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Bab Boy",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Whamfantastic.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Love Machine",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Whamfantastic.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Come On",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Whamfantastic.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Young Guns",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Whamfantastic.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Like A Baby",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Wham!MakeItBig.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Freedom",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Wham!MakeItBig.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "If You Were There",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Wham!MakeItBig.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Heartbeat",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Wham!MakeItBig.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Faith",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Faith.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Hard Day",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Faith.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "One More Try",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Faith.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Father Figure",
                        Artists = "George Michael ",
                        Author = "George Michael ",
                        UrlImage = "Faith.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Intro",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "Back to Basics.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Back In The Day",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "Back to Basics.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "F.U.S.S",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "Back to Basics.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Oh Mother",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "Back to Basics.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Dirrty",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "Stripped.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Beautiful",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "Stripped.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Can't Hold Us Down",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "Stripped.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Fighter",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "Stripped.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "The Voice Within",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "Stripped.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Genie in a Bottle",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "ChristinaAguilera.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "What a Girl Wants",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "ChristinaAguilera.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "I Turn to You",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "ChristinaAguilera.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Reflection",
                        Artists = "Christina María Aguilera",
                        Author = "Christina María Aguilera",
                        UrlImage = "ChristinaAguilera.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Just Dance",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "TheFame.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "LoveGame",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "TheFame.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Paparazzi",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "TheFame.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Poker Face",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "TheFame.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "The Fame",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "TheFame.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Boys Boys Boys",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "TheFame.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Beautiful, Dirty, Rich",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "TheFame.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Money Honey",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "TheFame.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Aura",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "Artpop.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Venus",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "Artpop.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "G.U.Y.",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "Artpop.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Do What U Want",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "Artpop.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Artpop",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "Artpop.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Dope",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "Artpop.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Anything Goes",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "CheektoCheek.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Cheek to Cheek",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "CheektoCheek.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Nature Boy",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "CheektoCheek.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "I Won't Dance",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "CheektoCheek.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Firefly",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "CheektoCheek.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Lush Life",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "CheektoCheek.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "Sophisticated Lady",
                        Artists = "Lady Gaga",
                        Author = "Lady Gaga",
                        UrlImage = "CheektoCheek.jpg",
                        Category = "Pop"

                    },
                    new Song
                    {
                        Title = "They Said",
                        Artists = "BinZ",
                        Author = "BinZ",
                        UrlImage = "TheySaid.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Sao cũng được",
                        Artists = "BinZ",
                        Author = "BinZ",
                        UrlImage = "Saocungduoc.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Gene",
                        Artists = "BinZ",
                        Author = "BinZ",
                        UrlImage = "Gene.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "So Far",
                        Artists = "BinZ",
                        Author = "BinZ",
                        UrlImage = "SoFar.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "OK",
                        Artists = "BinZ",
                        Author = "BinZ",
                        UrlImage = "OK.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Big City Boy",
                        Artists = "BinZ",
                        Author = "BinZ",
                        UrlImage = "BigCityBoy.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Ế",
                        Artists = "Karik",
                        Author = "Karik",
                        UrlImage = "E.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Cứ là mình",
                        Artists = "Karik",
                        Author = "Karik",
                        UrlImage = "Culaminh.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Không ổn",
                        Artists = "Karik",
                        Author = "Karik",
                        UrlImage = "Khongon.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Anh là sinh viên",
                        Artists = "Karik",
                        Author = "Karik",
                        UrlImage = "Anhlasinhvien.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Từng là tất cả",
                        Artists = "Karik",
                        Author = "Karik",
                        UrlImage = "Tunglatatca.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Yêu em quá đi",
                        Artists = "Karik",
                        Author = "Karik",
                        UrlImage = "Yeuemquadi.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Đòi quà cứ ra tòa",
                        Artists = "Karik",
                        Author = "Karik",
                        UrlImage = "Doiquacuratoa.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Anh là của em",
                        Artists = "Karik",
                        Author = "Karik",
                        UrlImage = "Anhlacuaem.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Yêu 5",
                        Artists = "Rhymastic",
                        Author = "Rhymastic",
                        UrlImage = "Yeu5.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Nến và Hoa",
                        Artists = "Rhymastic",
                        Author = "Rhymastic",
                        UrlImage = "NenvaHoa.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Đây là Việt Nam",
                        Artists = "Rhymastic",
                        Author = "Rhymastic",
                        UrlImage = "DaylaVN.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Cần",
                        Artists = "Rhymastic",
                        Author = "Rhymastic",
                        UrlImage = "Rhymastic.jpg",
                        Category = "Rap"

                    });
                context.Songs.AddRange(
                    new Song
                    {
                        Title = "Vui đi em",
                        Artists = "Rhymastic",
                        Author = "Rhymastic",
                        UrlImage = "Rhymastic.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Vẽ khói",
                        Artists = "Rhymastic",
                        Author = "Rhymastic",
                        UrlImage = "Rhymastic.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Forever Alone",
                        Artists = "Justatee",
                        Author = "Justatee",
                        UrlImage = "Justatee.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Bâng khuâng",
                        Artists = "Justatee",
                        Author = "Justatee",
                        UrlImage = "Bangkhuang.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Crying Over You",
                        Artists = "Justatee",
                        Author = "Justatee",
                        UrlImage = "Crying.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Đã lỡ yêu em nhiều",
                        Artists = "Justatee",
                        Author = "Justatee",
                        UrlImage = "Justatee.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "LUS",
                        Artists = "Justatee",
                        Author = "Justatee",
                        UrlImage = "Lus.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Hết Mana",
                        Artists = "Justatee",
                        Author = "Justatee",
                        UrlImage = "Hetmana.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Lối nhỏ",
                        Artists = "Đen Vâu",
                        Author = "Đen Vâu",
                        UrlImage = "denvau.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Trời hôm nay nhiều mây cực",
                        Artists = "Đen Vâu",
                        Author = "Đen Vâu",
                        UrlImage = "troihomnay.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Một triệu like",
                        Artists = "Đen Vâu",
                        Author = "Đen Vâu",
                        UrlImage = "Đen.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Hai triệu năm",
                        Artists = "Đen Vâu",
                        Author = "Đen Vâu",
                        UrlImage = "2trieunam.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Đi về nhà",
                        Artists = "Đen Vâu",
                        Author = "Đen Vâu",
                        UrlImage = "Divenha.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Cảm ơn",
                        Artists = "Đen Vâu",
                        Author = "Đen Vâu",
                        UrlImage = "denvau.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Mười năm",
                        Artists = "Đen Vâu",
                        Author = "Đen Vâu",
                        UrlImage = "Đen.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Đố em biết anh đang nghĩ gì",
                        Artists = "Đen Vâu",
                        Author = "Đen Vâu",
                        UrlImage = "Doembiet.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Ngày khác lạ",
                        Artists = "Đen Vâu",
                        Author = "Đen Vâu",
                        UrlImage = "Đen.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Chạy",
                        Artists = "Wowy",
                        Author = "Wowy",
                        UrlImage = "Chay.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Bay thật xa",
                        Artists = "Wowy",
                        Author = "Wowy",
                        UrlImage = "Bay.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Lạc quan",
                        Artists = "Wowy",
                        Author = "Wowy",
                        UrlImage = "Wowy.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Thiên đàng",
                        Artists = "Wowy",
                        Author = "Wowy",
                        UrlImage = "Thiendang.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Brother",
                        Artists = "Wowy",
                        Author = "Wowy",
                        UrlImage = "Brother.jpg",
                        Category = "Rap"

                    },
                    new Song
                    {
                        Title = "Hướng dương",
                        Artists = "Wowy",
                        Author = "Wowy",
                        UrlImage = "Huongduong.jpg",
                        Category = "Rap"

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
                    },
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
                    },
                    new Artists
                    {
                        Name = "George Michael",
                        Birthday = "25/6/1963",
                        Gender = "Nam",
                        Contact = "GeorgeMichael.com",
                        UrlImage = "GeorgeMichael.jpg"
                    },
                    new Artists
                    {
                        Name = "Christina María Aguilera",
                        Birthday = "18/12/1980",
                        Gender = "Nữ",
                        Contact = "ChristinaMaríaAguilera.com",
                        UrlImage = "ChristinaMaríaAguilera.jpg"
                    },
                    new Artists
                    {
                        Name = "Lady Gaga",
                        Birthday = "28/3/1985",
                        Gender = "Nữ",
                        Contact = "LadyGaga.com",
                        UrlImage = "LadyGaga.jpg"
                    },
                    new Artists
                    {
                        Name = "BinZ",
                        Birthday = "24/5/1988",
                        Gender = "Nam",
                        Contact = "Binz.com",
                        UrlImage = "Binz.jpg"
                    },
                    new Artists
                    {
                        Name = "Karik",
                        Birthday = "12/4/1989",
                        Gender = "Nam",
                        Contact = ".com",
                        UrlImage = "Karik.jpg"
                    },
                    new Artists
                    {
                        Name = "Rhymastic",
                        Birthday = "8/4/1991",
                        Gender = "Nam",
                        Contact = "Rhymastic.com",
                        UrlImage = "Rhymastic.jpg"
                    },
                    new Artists
                    {
                        Name = "Justatee",
                        Birthday = "1/11/1991",
                        Gender = "Nam",
                        Contact = "Justatee.com",
                        UrlImage = "Justatee.jpg"
                    },
                    new Artists
                    {
                        Name = "Đen Vâu",
                        Birthday = "13/5/1989",
                        Gender = "Nam",
                        Contact = "Đen Vâu.com",
                        UrlImage = "Đen.jpg"
                    },
                    new Artists
                    {
                        Name = "Wowy",
                        Birthday = "27/9/1988",
                        Gender = "Nam",
                        Contact = "Wowy.com",
                        UrlImage = "Wowy.jpg"
                    });
            }
            context.SaveChanges();
        }
        
    }
   
}
