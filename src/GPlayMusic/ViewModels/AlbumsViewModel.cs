using System;
using System.Collections.ObjectModel;
using GPlayMusic.Models;
using MvvmHelpers;

namespace GPlayMusic.ViewModels
{
    public class AlbumsViewModel : BaseViewModel
    {
        public AlbumsViewModel()
        {
            Title = "Library";

            Cards = new ObservableCollection<SquareCard>
            {
                new SquareCard
                {
                    Title = "S&M • Metallica",
                    ImageUrl = "https://www.lamusica.com.co/tienda/wp-content/uploads/2019/05/ms-metallica-1.jpg"
                },
                new SquareCard
                {
                    Title = "Beerbongs & Bentleys • Post Malone",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/71ESoNkb%2BvL._SX355_.jpg"
                },
                new SquareCard
                {
                    Title = "bad guy • Billie Eilish",
                    ImageUrl = "https://static.fnac-static.com/multimedia/Images/ES/NR/08/1c/4d/5053448/1540-1.jpg"
                },
                new SquareCard
                {
                    Title = "thank u, next • Ariana Grande",
                    ImageUrl = "https://img.vavel.com/dxu2f6jvaaenmn9-1548946192672.jpg"
                },
                new SquareCard
                {
                    Title = "X 100PRE • Bad Bunny",
                    ImageUrl = "http://www.elgenero.com/images/subir/images/15455926941jbpqaf.jpg"
                }
            };
        }

        public ObservableCollection<SquareCard> Cards { get; }
    }
}
