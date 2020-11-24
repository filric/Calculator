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

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        String tal1 = "";
        String tal2 = "";
        String svar = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                MyTextBlock.Text += button.Content;
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            int resultat = 0;
            if (MyTextBlock.Text.IndexOf("+")>=0)
            {
                tal1 = MyTextBlock.Text.Substring(0, MyTextBlock.Text.IndexOf("+"));
                tal2 = MyTextBlock.Text.Substring(MyTextBlock.Text.IndexOf("+") + 1);
                resultat = int.Parse(tal1) + int.Parse(tal2);
                svar = resultat.ToString();
            }
            if (MyTextBlock.Text.IndexOf("-")>=0)
            {
                tal1 = MyTextBlock.Text.Substring(0, MyTextBlock.Text.IndexOf("-"));
                tal2 = MyTextBlock.Text.Substring(MyTextBlock.Text.IndexOf("-") + 1);
                resultat = int.Parse(tal1) - int.Parse(tal2);
                svar = resultat.ToString();
            }
            if (MyTextBlock.Text.IndexOf("x") >= 0)
            {
                tal1 = MyTextBlock.Text.Substring(0, MyTextBlock.Text.IndexOf("x"));
                tal2 = MyTextBlock.Text.Substring(MyTextBlock.Text.IndexOf("x") + 1);
                resultat = int.Parse(tal1) * int.Parse(tal2);
                svar = resultat.ToString();
            }
            if (MyTextBlock.Text.IndexOf("/") >= 0)
            {
                tal1 = MyTextBlock.Text.Substring(0, MyTextBlock.Text.IndexOf("/"));
                tal2 = MyTextBlock.Text.Substring(MyTextBlock.Text.IndexOf("/") + 1);
                int kollaNollan = int.Parse(tal2);
                if (kollaNollan != 0)
                {
                    resultat = int.Parse(tal1) / int.Parse(tal2);
                    svar = resultat.ToString();
                }
                else
                {
                    svar = "ERROR";
                }
            }

            MyTextBlock.Text = svar;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            MyTextBlock.Text = "";
            tal1 = "";
            tal2 = "";
            svar = "";
        }
    }
}
