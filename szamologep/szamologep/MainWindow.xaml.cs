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

namespace szamologep
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

        private void btnOsszead_Click(object sender, RoutedEventArgs e)
        {
            double aSzam = Convert.ToDouble(txtAszam.Text);
            double bSzam = Convert.ToDouble(txtBszam.Text);
            double eredemeny = aSzam + bSzam;
            MessageBox.Show("Az összeadás eredménye: " + eredemeny);
        }

        private void btnKivon_Click(object sender, RoutedEventArgs e)
        {
            double aSzam = Convert.ToDouble(txtAszam.Text);
            double bSzam = Convert.ToDouble(txtBszam.Text);
            double eredemeny = aSzam - bSzam;
            MessageBox.Show("A kivonás eredménye: " + eredemeny);
        }

        private void btnSzoroz_Click(object sender, RoutedEventArgs e)
        {
            double aSzam = Convert.ToDouble(txtAszam.Text);
            double bSzam = Convert.ToDouble(txtBszam.Text);
            double eredemeny = aSzam * bSzam;
            MessageBox.Show("A szorzás eredménye: " + eredemeny);
        }

        private void btnOszt_Click(object sender, RoutedEventArgs e)
        {
            double aSzam = Convert.ToDouble(txtAszam.Text);
            double bSzam = Convert.ToDouble(txtBszam.Text);
            double eredemeny = aSzam / bSzam;
            MessageBox.Show("Az osztás eredménye: " + eredemeny);
        }

        private void btnHatvanyozas_Click(object sender, RoutedEventArgs e)
        {
            double aSzam = Convert.ToDouble(txtAszam.Text);
            double bSzam = Convert.ToDouble(txtBszam.Text);
            double eredemeny = Math.Pow(aSzam, bSzam);
            MessageBox.Show("A hatványozás eredménye: " + eredemeny);
        }
    }
}
