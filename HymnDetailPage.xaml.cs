using Microsoft.Maui.Controls;
using YorubaCatholicHymn.Models;
using YorubaCatholicHymn.Data;
using YorubaCatholicHymn.ViewModels;
using System.Linq;

namespace YorubaCatholicHymn
{
    [QueryProperty(nameof(HymnNumber), "number")]
    public partial class HymnDetailPage : ContentPage
    {
        public HymnDetailPage()
        {
            InitializeComponent();
        }

        public string HymnNumber
        {
            set
            {
                var hymn = HymnData.Hymns.FirstOrDefault(h => h.Number == value);
                if (hymn != null)
                    BindingContext = new DetailPageViewModel(hymn);
            }
        }
    }
}
