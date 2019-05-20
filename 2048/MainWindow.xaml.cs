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

namespace _2048
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            scoreText.Content = "100";
            theBestText.Content = "20343";
        }

        bool hide = false;
        private void menuOpen_click(object sender, MouseButtonEventArgs e)
        {
           if(hide)
           {
                hide_all.Visibility = Visibility.Hidden;
                back_menu.Visibility = Visibility.Hidden;
                front_menu.Visibility = Visibility.Hidden;

                hide = false;
           }
           else
            {
                hide_all.Visibility = Visibility.Visible;
                back_menu.Visibility = Visibility.Visible;
                front_menu.Visibility = Visibility.Visible;

                hide = true;
           }
        }

        private void NewGame_button_MouseEnter(object sender, MouseEventArgs e)
        {
            Brush br = new SolidColorBrush(Color.FromArgb(255, 75, 75, 75));
            NewGame_button.Background = br;
        }

        private void _2048Menu_Copy1_MouseEnter(object sender, MouseEventArgs e)
        {
            Brush br = new SolidColorBrush(Color.FromArgb(255, 75, 75, 75));
            _2048Menu_Copy1.Background = br;
        }

        private void NewGame_button_MouseLeave(object sender, MouseEventArgs e)
        {
            Brush br = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            NewGame_button.Background = br;
        }

        private void _2048Menu_Copy1_MouseLeave(object sender, MouseEventArgs e)
        {
            Brush br = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            _2048Menu_Copy1.Background = br;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Left)
            {
            }
        }
    }
}
