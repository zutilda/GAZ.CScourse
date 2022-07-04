﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SquareRoots
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Get a double from the TextBox
            double numberDouble;
            if (!double.TryParse(inputTextBox.Text, out numberDouble))
            {
                MessageBox.Show("Please enter a double");
                return;
            }

            // Check that the user has entered a positive number
            if (numberDouble <= 0)
            {
                MessageBox.Show("Please enter a positive number");
                return;
            }

            // Use the .NET Framework Math.Sqrt method
            double squareRoot = Math.Sqrt(numberDouble);

            // Format the result and display it
            frameworkLabel.Content = string.Format("{0} (Using .NET Framework)", squareRoot);

            // Newton's method for calculating square roots

            // Get the user input as a decimal
            decimal numberDecimal;
            if (!decimal.TryParse(inputTextBox.Text, out numberDecimal))
            {
                MessageBox.Show("Please enter a decimal");
                return;
            }

           
            decimal delta = Convert.ToDecimal(Math.Pow(10, -28));

            // Take an initial guess at an answer to get started
            decimal guess = numberDecimal / 2;

            // Estimate result for the first iteration
            decimal result = ((numberDecimal / guess) + guess) / 2;

            
            while (Math.Abs(result - guess) > delta)
            {
                // Use the result from the previous iteration as our starting point
                guess = result;
                // Try again
                result = ((numberDecimal / guess) + guess) / 2;
            }

            // Display the result
            newtonLabel.Content = string.Format("{0} (Using Newton)", result);
        }
    }
}
