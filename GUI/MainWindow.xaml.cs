﻿using GUI.Views.Components;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private int[] dataPoints = { 3, 5, 8, 4, 7, 2 };
        public MainWindow()
        {
            InitializeComponent();
          
        }
 
        protected void Button_Clicked(object sender, RoutedEventArgs e)
        {
            lstPort.Items.Clear();
            lstPort.Items.Add("Com1");
            lstPort.Items.Add("Com2");
           
        }






    }
}
