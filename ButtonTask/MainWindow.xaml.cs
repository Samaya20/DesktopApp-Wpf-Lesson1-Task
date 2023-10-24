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

namespace ButtonTask
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Random random = new Random();

            var color = String.Format("#{0:X6}", random.Next(0x1000000));

            button.Background = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFromString(color);

            MessageBox.Show($"Sıra nömrəsi: {button.Content},\nRəngi: {button.Background}");
        }

        private void Button_RightClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Button button = (Button)sender;
            int buttonNumber = int.Parse(button.Content.ToString());

            button.Visibility = Visibility.Hidden;

            this.Title = $" Sıra nömrəsi: {buttonNumber}";
        }
    }
}
