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
        int i = 1;
        String tal1 = "";
        String tal2 = "";
        String tecken = "";
        String svar = "";
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            int x = 1;
            do {
                MyTextBlock.Inlines.Add(tal1 + tecken + tal2 + svar);
            } while (x == 1);
        }

        public void addTecken(String s)
        {
            if (i == 1)
            {
                tal1 = tal1 + s;
            }
            else
            {
                tal2 = tal2 + s;
            }
        }
            

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            addTecken("1");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            addTecken("2");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            addTecken("3");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            addTecken("4");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            addTecken("5");
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            addTecken("6");
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            addTecken("7");
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            addTecken("8");
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            addTecken("9");
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            addTecken("0");
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (float.Parse(tal2) != 0)
            {
                float resultat = 0;
                switch (tecken)
                {
                    case "+":
                        resultat = float.Parse(tal1) + float.Parse(tal2);
                        break;
                    case "-":
                        resultat = float.Parse(tal1) - float.Parse(tal2);
                        break;
                    case "x":
                        resultat = float.Parse(tal1) * float.Parse(tal2);
                        break;
                    case "/":
                        resultat = float.Parse(tal1) / float.Parse(tal2);
                        break;
                    default:

                        break;

                }

                svar = "=" + resultat.ToString();
            }
            else
            {
                svar = "ERROR";
            }
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            tecken = "+";
            i = 2;
        }

        private void Subtraktion_Click(object sender, RoutedEventArgs e)
        {
            tecken = "-";
            i = 2;
        }

        private void Multiplikation_Click(object sender, RoutedEventArgs e)
        {
            tecken = "x";
            i = 2;
        }

        private void Divition_Click(object sender, RoutedEventArgs e)
        {
            tecken = "/";
            i = 2;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            tecken = "";
            tal1 = "";
            tal2 = "";
            svar = "";
        }

        private void ButtonDecimal_Click(object sender, RoutedEventArgs e)
        {
            addTecken(",");
        }
    }
}
