using System;
using System.Collections.Generic;
using System.Text;

namespace test_SfNumericTextBox
{
    public class MainPageViewModel
    {

        public MainPageViewModel()
        {
            // Set default value
            prp_Value = 0.0125M;
            prp_MaximumNumberDecimalDigits = 4;
        }

        private decimal prp_Value;
        public decimal Value
        {
            get { return prp_Value; }
            set { prp_Value = value; }
        }


        private int prp_MaximumNumberDecimalDigits;
        public int MaximumNumberDecimalDigits
        {
            get { return prp_MaximumNumberDecimalDigits; }
            set { prp_MaximumNumberDecimalDigits = value; }
        }

    }
}
