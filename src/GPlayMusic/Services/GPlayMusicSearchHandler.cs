using System;
using System.Collections.Generic;
using System.Linq;
using GPlayMusic.Models;
using Xamarin.Forms;

namespace GPlayMusic.Services
{
    public class GPlayMusicSearchHandler : SearchHandler
    {
        public static List<Artist> Artists { get; } = new List<Artist>
        {
            new Artist
            {
                Name = "Bad Bunny",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/812r+bAyUML.jpg"
            },
            new Artist
            {
                Name = "Snoop Dogg",
                ImageUrl = "http://www.hhgroups.com/imagenes/artistas/snoop-dogg-artista.jpg"
            },
            new Artist
            {
                Name = "Daddy Yankee",
                ImageUrl = "http://e-cdn-images.deezer.com/images/artist/5f45206580cde1388f71ccc7f8226768/500x500.jpg"
            },
            new Artist
            {
                Name = "Ariana Grande",
                ImageUrl = "https://content-images.p-cdn.com/images/d6/11/26/56/612a46ad8015bec36381deef/_500W_500H.jpg"
            },
            new Artist
            {
                Name = "Siddhartha",
                ImageUrl = "https://i.musicaimg.com/letras/500/2445589.jpg"
            },
            new Artist
            {
                Name = "Post Malone",
                ImageUrl = "https://i1.sndcdn.com/avatars-000404451534-thnhi5-t500x500.jpg"
            },
            new Artist
            {
                Name = "Billie Eilish",
                ImageUrl = "https://y.gtimg.cn/music/photo_new/T001R500x500M0000034MZS446AF7O.jpg"
            }
        };

        public GPlayMusicSearchHandler()
        {
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = Artists.OrderBy(item => item.Name);
            }
            else
            {
                ItemsSource = Artists.Where(item => item.Name.ToLower().Contains(newValue.ToLower())).OrderBy(item => item.Name).ToList<Artist>();
            }
        }
    }
}
