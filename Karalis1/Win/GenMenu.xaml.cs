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
using System.Windows.Shapes;

namespace Karalis1.Win
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class GenMenu : Window
    {
        public GenMenu()
        {
            InitializeComponent();
        }
        
        private void Private_Click(object sender, RoutedEventArgs e)
        {
            WinGo winGo = new WinGo();
            winGo.Show();
            Close();
        }
    }
}
