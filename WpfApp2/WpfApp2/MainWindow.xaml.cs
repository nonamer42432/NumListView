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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _currentNumber = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_click(object sender, RoutedEventArgs e)
        {
            _currentNumber++;
            NumListView.Items.Add(_currentNumber);
        }

        private void DelButton_click(Object sender, RoutedEventArgs e)
        {
            if (NumListView.SelectedItem != null)
            {
                NumListView.Items.Remove(NumListView.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите число для удаления");
            }
        }
    }
}
