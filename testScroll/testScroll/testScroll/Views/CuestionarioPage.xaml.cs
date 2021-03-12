using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testScroll.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testScroll.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CuestionarioPage : ContentPage
    {
        public CuestionarioPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            if (BindingContext is CuestionarioViewModel viewModel) viewModel.OnAppearing(this.BindingContext);
        }
        protected override void OnDisappearing()
        {
            if (BindingContext is CuestionarioViewModel viewModel) viewModel.OnDisappearing();
        }
    }
}