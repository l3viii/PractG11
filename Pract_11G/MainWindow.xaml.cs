using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Pract_11G
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

        private void FindFirstLine_Click(object sender, RoutedEventArgs e)
        {
            numbers.Items.Clear();
            string phrase = firstLine.Text;
            Regex regex = new Regex(@"2(\D{0,})3");
            MatchCollection match = regex.Matches(phrase);
            object[] array = new object[match.Count];
            match.CopyTo(array, 0);
            for (int i = 0; i < match.Count; i++)
            {
                numbers.Items.Add(match[i]);
            }
        }

        private void FindSecondLine_Click(object sender, RoutedEventArgs e)
        {
            numbers.Items.Clear();
            string phrase = secondLine.Text;
            Regex regex = new Regex(@"(\*q+\+)");
            MatchCollection match = regex.Matches(phrase);
            object[] array = new object[match.Count];
            match.CopyTo(array, 0);
            for (int i = 0; i < match.Count; i++)
            {
                numbers.Items.Add(match[i]);
            }
        }

        private void AboutProgramm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил: Дроздов Г.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
