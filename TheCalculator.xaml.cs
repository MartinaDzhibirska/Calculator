using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class TheCalculator : Window
    {
        CalculatorViewModel calcViewModel = new CalculatorViewModel();
        public TheCalculator()
        {
            InitializeComponent();
            this.DataContext = calcViewModel;
        }

        /// <summary>
        /// Event Handlers calling the Calculate method when an operation button is clicked.
        /// </summary>
       
        #region Operations

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.Calculate("+");
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.Calculate("/");
        }       

        private void Substract_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.Calculate("-");
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.Equals();
        }  

        private void SquareRoot_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.Calculate("S");
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.Calculate("^");
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.Calculate("*");
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.Clear();
        }       
        
        #endregion

        /// <summary>
        /// Event handlers calling the ShowNumber method when a number button is clicked.
        /// </summary>
  
        #region NumberEvents

        private void NumberZero_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.ShowNumber("0");
        }

        private void NumberOne_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.ShowNumber("1");
        }

        private void NumberTwo_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.ShowNumber("2");
        }

        private void NumberThree_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.ShowNumber("3");
        }

        private void NumberFour_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.ShowNumber("4");
        }

        private void NumberFive_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.ShowNumber("5");
        }

        private void NumberSix_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.ShowNumber("6");
        }

        private void NumberSeven_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.ShowNumber("7");
        }

        private void NumberEight_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.ShowNumber("8");
        }

        private void NumberNine_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.ShowNumber("9");
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            calcViewModel.ShowNumber(".");
        }

        #endregion
        
    }
}
