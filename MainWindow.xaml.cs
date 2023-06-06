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

namespace WPFApp1
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

        string text;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (getInput.IsEnabled == false)
            {
                if (pwBox.IsEnabled == true)
                {
                    if (pwBox.Password == "admin")
                    {
                        MessageBox.Show("SUCCESS!!!");
                    }
                    else
                    {
                        MessageBox.Show("FAIL!!!");
                    }

                }
                else
                {
                    if (knopfGut.IsChecked == true)
                    {
                        MessageBox.Show("Gut, dass es dir gut geht!");
                    }
                    else if (knopfSchlecht.IsChecked == true)
                    {
                        MessageBox.Show("Aww, was auch immer dich momentan schlecht fühlen lässt, ich hoffe, dass es bald vorbei sein wird!");
                    }
                    else
                    {
                        MessageBox.Show("Fehler: Keine Auswahl.");
                    }
                }
                
            }
            if (getInput.IsEnabled == true)
            {
                text = getInput.Text;
                if (text == "")
                {
                    MessageBox.Show("Die Leere. Die unendliche Leere.");
                }
                else
                {
                    MessageBox.Show(text);
                }
                
            }
            
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (getInput.IsEnabled == false)
            {
                pwText.IsEnabled = false;
                pwText.Opacity = 0;
                getInput.Opacity = 100;
                pwBox.IsEnabled = false;
                pwBox.Opacity = 0;
                getInput.IsEnabled = true;
                knopfGut.IsEnabled = false;
                knopfSchlecht.IsEnabled = false;
                echo.Content = "Textechomodus";
                PwEnabledCheck();
            }
            else if (pwBox.IsEnabled == true)
            {
                pwBox.IsEnabled = false;
                pwBox.Opacity = 0;
                getInput.Opacity = 100;
                PwEnabledCheck();
            }
            else
            {
                pwText.IsEnabled = false;
                pwText.Opacity = 0;
                getInput.Opacity = 100;
                pwBox.IsEnabled = false;
                pwBox.Opacity = 0;
                getInput.IsEnabled = false;
                knopfGut.IsEnabled = true;
                knopfSchlecht.IsEnabled = true;
                echo.Content = "Auswahlmodus";
                PwEnabledCheck();
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            getInput.Text = "";
            knopfGut.IsChecked = false;
            knopfSchlecht.IsChecked = false;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            knopfGut.IsChecked = false;
            knopfSchlecht.IsChecked = false;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            getInput.Text = "";
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            /*PasswordEnter pwEnter = new PasswordEnter();
            pwEnter.Show();*/
            getInput.IsEnabled = false;
            knopfGut.IsEnabled = false;
            knopfSchlecht.IsEnabled = false;
            echo.Content = "Passwortmodus";
            getInput.IsEnabled = false;
            getInput.Opacity = 0;
            pwBox.IsEnabled = true;
            pwBox.Opacity = 100;
            PwEnabledCheck();
            
        }
        void PwEnabledCheck()
        {
            if (pwBox.IsEnabled == true)
            {
                pwText.IsEnabled = true;
                pwText.Opacity = 100;
                pwText.IsHitTestVisible = true;
                pwBox.IsHitTestVisible = true;
            }
            else
            {
                pwText.IsEnabled = false;
                pwText.Opacity = 0;
                pwText.IsHitTestVisible = false;
                pwBox.IsHitTestVisible = false;
            }
        }
    }
}
