using primera_calculadora.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace primera_calculadora.Views
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