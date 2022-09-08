using biblioteca_3_1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace biblioteca_3_1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}