using System;
using System.Collections.ObjectModel;
using GPlayMusic.Models;
using MvvmHelpers;

namespace GPlayMusic.ViewModels
{
    public class PlaylistsViewModel : BaseViewModel
    {
        public PlaylistsViewModel()
        {
            Title = "Library";
            Cards = new ObservableCollection<SquareCard>
            {
                new SquareCard
                {
                    Title = "Reggaeton",
                    ImageUrl = "https://www.impacrecords.com/wp-content/uploads/2018/04/JBalvinAmbiente-1.png"
                },
                new SquareCard
                {
                    Title = "Indie",
                    ImageUrl = "https://images.genius.com/ba268fbd6e7d58ae46f2fdf632b3493e.600x600x1.jpg"
                }
            };
        }

        public ObservableCollection<SquareCard> Cards { get; }
    }
}
