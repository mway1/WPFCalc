﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calc.WPF
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

        private void ButtonPlus_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            TextBlockOutput.Text += "0";
        }

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(ButtonOne.Content);
            TextBlockOutput.Text += $"{n} ";

        }
    }
}
