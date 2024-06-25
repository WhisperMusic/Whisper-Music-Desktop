using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Whisper_Music.Animations;

namespace Whisper_Music
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) =>
            this.DragMove();
        
        private void Close(object sender, RoutedEventArgs e) =>
            Application.Current.Shutdown();

        private void Minimize(object sender, RoutedEventArgs e) =>
            this.WindowState = WindowState.Minimized;

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal) this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }
    }
}
