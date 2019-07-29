using System;
using System.Collections.ObjectModel;
using GPlayMusic.Models;
using MvvmHelpers;

namespace GPlayMusic.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Title = "Home";
            Cards = new ObservableCollection<HomeCard>
            {
                new HomeCard
                {
                    Title = "Top Albums",
                    SubTitle = "OASIS",
                    Details = "Album by Bad Bunny & J Balvin • 8 songs",
                    ImageUrl = "https://www.radioactiva.cl/wp-content/uploads/2019/07/bad.jpg"
                },
                new HomeCard
                {
                    Title = "Recommended new releases",
                    SubTitle = "Portratit of The Dogg",
                    Details = "Album by Snoop Dogg • 12 songs",
                    ImageUrl = "https://direct.rhapsody.com/imageserver/images/alb.394056178/500x500.jpg"
                },
                new HomeCard
                {
                    Title = "Playing Near You",
                    SubTitle = "Alemán",
                    Details = "Friday, 18 Oct",
                    ImageUrl = "https://yt3.ggpht.com/a/AGF-l79MTIhLC8Y-EFKq2Kl7FaqihciB3geKMPnbNw=s288-c-k-c0xffffffff-no-rj-mo"
                }
            };
        }

        public ObservableCollection<HomeCard> Cards { get; }
    }
}
