using Simple_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_Calculator.ViewModels
{
    public class CalculatorViewModel
    {
        private CalculatorModel _calculatorModel = new CalculatorModel();

        public CalculatorModel CalculatorModel
        {
            get { return _calculatorModel; }
            set { _calculatorModel = value ?? new CalculatorModel(); }
        }
    }
}