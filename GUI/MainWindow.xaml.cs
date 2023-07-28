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
        private int[] dataPoints = { 3, 5, 8, 4, 7, 2 };
        public MainWindow()
        {
            InitializeComponent();
        }
 

 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            canvas.Children.Clear();

             
            double graphWidth = 400;
            double graphHeight = 300;

            
            int maxValue = 0;
            foreach (int dataPoint in dataPoints)
            {
                if (dataPoint > maxValue)
                    maxValue = dataPoint;
            }

             
            double barWidth = graphWidth / dataPoints.Length;

           
            for (int i = 0; i < dataPoints.Length; i++)
            {
                double barHeight = dataPoints[i] * graphHeight / maxValue;

                Rectangle bar = new Rectangle
                {
                    Width = barWidth,
                    Height = barHeight,
                    Fill = Brushes.Blue
                };

                Canvas.SetLeft(bar, i * barWidth);
                Canvas.SetTop(bar, graphHeight - barHeight);

                canvas.Children.Add(bar);
            }
        }



    }
}
