using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GUI.Views.Components
{
    /// <summary>
    /// Interaction logic for UserInput.xaml
    /// </summary>
    public partial class UserInput : UserControl
    {
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(UserInput), new PropertyMetadata("Label"));

     
        public static readonly DependencyProperty ItemsProperty =
           DependencyProperty.Register("Items", typeof(ObservableCollection<string>), typeof(UserInput), 
               new PropertyMetadata(new ObservableCollection<string>()));

        // Event 
        public static readonly RoutedEvent ButtonClickedEvent =
           EventManager.RegisterRoutedEvent("ButtonClicked", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(UserInput));


        public ObservableCollection<string> Items
        {
            get { return (ObservableCollection<string>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public string LabelText
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

    
        public UserInput()
        {
            InitializeComponent();
            Items=new ObservableCollection<string>();
            lstBox.ItemsSource= Items;
        }

        public event RoutedEventHandler ButtonClicked
        {
            add { AddHandler(ButtonClickedEvent, value); }
            remove { RemoveHandler(ButtonClickedEvent, value); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            RaiseEvent(new RoutedEventArgs(ButtonClickedEvent));
        }

    }
}
