using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test_SfNumericTextBox
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SfNumericTextBoxPage : ContentPage
    {

        SfNumericTextBoxViewModel lc_SfNumericTextBoxViewModel = null;

        public SfNumericTextBoxPage(decimal u_Value, int u_MaximumNumberDecimalDigits)
        {
            InitializeComponent();

            lc_SfNumericTextBoxViewModel = new SfNumericTextBoxViewModel(u_Value: u_Value, u_MaximumNumberDecimalDigits: u_MaximumNumberDecimalDigits);

            this.BindingContext = lc_SfNumericTextBoxViewModel;
        }
    }
}