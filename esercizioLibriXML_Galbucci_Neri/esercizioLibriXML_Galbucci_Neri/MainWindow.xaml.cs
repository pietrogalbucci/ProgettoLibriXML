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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace esercizioLibriXML_Galbucci_Neri
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Crea_Click(object sender, RoutedEventArgs e)
        {
            XDocument xmlDocument = XDocument.Load(@"C:\Users\matteo.neri\Desktop\esLibri Galbucci Neri\ProgettoLibriXML\esercizioLibriXML_Galbucci_Neri\esercizioLibriXML_Galbucci_Neri\libri.XML");
        }
    }
}
