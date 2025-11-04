using SurfRater.Maui.Models;
using SurfRater.Maui.PageModels;

namespace SurfRater.Maui.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}