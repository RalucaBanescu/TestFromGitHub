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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
            //btnHelloWorld.Content = "Click me! (from code behind)";
        }

        private void btnHelloWorld_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world!","Title of the window", MessageBoxButton.OKCancel, MessageBoxImage.Error);
        }
    }
}
