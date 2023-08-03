﻿using GUI.FileHandler;
using GUI.Views.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
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
        
        public MainWindow()
        {
            InitializeComponent();
          
        }
 
        protected void Button_Clicked(object sender, RoutedEventArgs e)
        {
            //Openfile dialog
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //MessageBox.Show(File.Exists(System.IO.Path.Combine(baseDirectory, "assets", "cube.stl")).ToString());
            string filePath = System.IO.Path.Combine(baseDirectory, "assets", "cube.stl");
            STLFileReader sTLFileReader = new STLFileReader();
            sTLFileReader.ReadFile(filePath);




        }






    }
}
