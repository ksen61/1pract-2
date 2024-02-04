using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace krstiki_noliki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random random = new Random();
        int ra;
        int ab = 0;
        List<string> list = new List<string>() { "", "", "",
                                                    "", "", "",
                                                    "", "", "" };
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement element in main_window.Children)
            {
                if (element is Button && element != start_game)
                {
                    ((Button)element).Click += Button_click;
                }
            }
        }
        public void Button_click(object sender, RoutedEventArgs e)
        {

            string symbol = "X";
            if (ab % 2 == 0)
            {
                symbol = "O";
            }
            else
            {
                symbol = "X";
            }
            ((Button)e.OriginalSource).Content = symbol;
            ((Button)e.OriginalSource).IsEnabled = false;
            bool check = list.Contains("");



            if (check == false)
            {
                Enablefalse();
            }
            else { Robot(); }

            win(((Button)e.OriginalSource).Content.ToString());
        }
        private void win(string ButtonContent)
        {
            if ((_1.Content == ButtonContent & _2.Content == ButtonContent & _3.Content == ButtonContent) | (_1.Content == ButtonContent & _4.Content == ButtonContent & _7.Content == ButtonContent)
                | (_1.Content == ButtonContent & _5.Content == ButtonContent & _9.Content == ButtonContent) | (_2.Content == ButtonContent & _5.Content == ButtonContent & _8.Content == ButtonContent)
                | (_3.Content == ButtonContent & _6.Content == ButtonContent & _9.Content == ButtonContent) | (_4.Content == ButtonContent & _5.Content == ButtonContent & _6.Content == ButtonContent)
                | (_7.Content == ButtonContent & _8.Content == ButtonContent & _9.Content == ButtonContent) | (_3.Content == ButtonContent & _5.Content == ButtonContent & _7.Content == ButtonContent))
            {
                if (ButtonContent == "O")
                {
                    Textblock.Text = "Победили нолики";
                }
                else if (ButtonContent == "X")
                {
                    Textblock.Text = "Победили крестики";
                }
                Enablefalse();
            }
            else
            {
                if (_1.IsEnabled == false && _2.IsEnabled == false && _3.IsEnabled == false && _4.IsEnabled == false && _5.IsEnabled == false && _6.IsEnabled == false && _7.IsEnabled == false && _8.IsEnabled == false && _9.IsEnabled == false)
                {
                    Textblock.Text = "Ничья";
                }



            }

        }
        public void Robot()
        {
            string symbol = "X";
            if (ab % 2 == 0)
            {
                symbol = "X";
            }
            else
            {
                symbol = "O";
            }
            bool tr = true;
            while (tr)
            {
                int ra = random.Next(1, 9);
                if (list[ra - 1] != "O" && list[ra - 1] != "X")
                {
                    switch (ra)
                    {
                        case 1:
                            _1.Content = symbol;
                            _1.IsEnabled = false;
                            list[0] = symbol;
                            break;
                        case 2:
                            _2.Content = symbol;
                            _2.IsEnabled = false;
                            list[1] = symbol;
                            break;
                        case 3:
                            _3.Content = symbol;
                            _3.IsEnabled = false;
                            list[2] = symbol;
                            break;
                        case 4:
                            _4.Content = symbol;
                            _4.IsEnabled = false;
                            list[3] = symbol;
                            break;
                        case 5:
                            _5.Content = symbol;
                            _5.IsEnabled = false;
                            list[4] = symbol;
                            break;
                        case 6:
                            _6.Content = symbol;
                            _6.IsEnabled = false;
                            list[5] = symbol;
                            break;
                        case 7:
                            _7.Content = symbol;
                            _7.IsEnabled = false;
                            list[6] = symbol;
                            break;
                        case 8:
                            _8.Content = symbol;
                            _8.IsEnabled = false;
                            list[7] = symbol;
                            break;
                        case 9:
                            _9.Content = symbol;
                            _9.IsEnabled = false;
                            list[8] = symbol;
                            break;
                        default: break;

                    }
                    tr = false;
                }
            }
        }
        public void Enabletrue()
        {

            foreach (UIElement element in main_window.Children)
            {
                if (element is Button)
                {
                    element.IsEnabled = true;

                }
            }
        }
        public void Enablefalse()
        {
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;
        }
        public void Ochistka()
        {
            _1.Content = " ";
            _2.Content = " ";
            _3.Content = " ";
            _4.Content = " ";
            _5.Content = " ";
            _6.Content = " ";
            _7.Content = " ";
            _8.Content = " ";
            _9.Content = " ";
            Textblock.Text = " ";
        }
        private void start_game_Click(object sender, RoutedEventArgs e)
        {
            Ochistka();
            for (int i = 0; i < 9; i++)
            {
                list[i] = "";
            }
            ab += 1;
            Enabletrue();
        }

        public string symbol()
        {
            string sym = "X";
            if (ab % 2 == 0)
            {
                sym = "O";
            }
            else
            {
                sym = "X";
            }
            return sym;
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            string sym = symbol();
            list[0] = sym;
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            string sym = symbol();
            list[1] = sym;
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            string sym = symbol();
            list[2] = sym;
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            string sym = symbol();
            list[3] = sym;
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            string sym = symbol();
            list[4] = sym;
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            string sym = symbol();
            list[5] = sym;
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            string sym = symbol();
            list[6] = sym;
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            string sym = symbol();
            list[7] = sym;
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            string sym = symbol();
            list[8] = sym;
        }
    }
}
