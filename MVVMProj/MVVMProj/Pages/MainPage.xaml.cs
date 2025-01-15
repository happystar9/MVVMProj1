using MVVMProj.Models;
using MVVMProj.PageModels;

namespace MVVMProj.Pages
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