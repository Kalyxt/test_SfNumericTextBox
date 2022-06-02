using System;
using System.Collections.Generic;
using System.Text;

namespace test_SfNumericTextBox
{
    public class SfNumericTextBoxViewModel
    {

        public SfNumericTextBoxViewModel(decimal u_Value, int u_MaximumNumberDecimalDigits)
        {

            prp_Value = u_Value;
            prp_MaximumNumberDecimalDigits = u_MaximumNumberDecimalDigits;
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
