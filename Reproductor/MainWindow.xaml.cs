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

namespace Reproductor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Trailer1_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Trailer_MediaElement.Source = new Uri("C:/Users/alumno/Desktop/trailers/trailer1.mp4");
            Trailer_MediaElement.Play();
        }

        private void Trailer2_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Trailer_MediaElement.Source = new Uri("C:/Users/alumno/Desktop/trailers/trailer2.mp4");
            Trailer_MediaElement.Play();
        }

        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            Trailer_MediaElement.Play();
        }

        private void Pause_Button_Click(object sender, RoutedEventArgs e)
        {
            Trailer_MediaElement.Pause();
        }

        private void Stop_Button_Click(object sender, RoutedEventArgs e)
        {
            Trailer_MediaElement.Stop();
        }

        private void Silencio_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Trailer_MediaElement.IsMuted = true;
        }

        private void Silencio_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Trailer_MediaElement.IsMuted = false;
        }
    }
}
