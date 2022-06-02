using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace test_SfNumericTextBox
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel lc_MainPageViewModel = null;

        public MainPage()
        {
            InitializeComponent();

            lc_MainPageViewModel = new MainPageViewModel();

            this.BindingContext = lc_MainPageViewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SfNumericTextBoxPage tmp_SfNumericTextBoxPage = new SfNumericTextBoxPage(lc_MainPageViewModel.Value, lc_MainPageViewModel.MaximumNumberDecimalDigits);
            this.Navigation.PushAsync(tmp_SfNumericTextBoxPage);
        }
    }
}
