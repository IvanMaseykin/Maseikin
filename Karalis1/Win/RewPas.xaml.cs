﻿using System;
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
    /// Логика взаимодействия для RewPas.xaml
    /// </summary>
    public partial class RewPas : Window
    {
        public RewPas()
        {
            InitializeComponent();
        }

        private void BRegEnd_Click(object sender, RoutedEventArgs e)
        {
            WinAvto winAvto = new WinAvto();
            winAvto.Show();
            this.Close();
        }
    }
}