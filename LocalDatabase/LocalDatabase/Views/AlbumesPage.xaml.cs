using LocalDatabase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDatabase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumesPage : ContentPage
    {
        public AlbumesPage()
        {
            InitializeComponent();
            this.BindingContext = new AlbumesViewModel();
        }
    }
}