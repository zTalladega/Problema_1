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

namespace Problema_1
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
        
        private void Clienti_Click_Add(object sender, RoutedEventArgs e)
        {
            FormularAdaugare.Visibility = Visibility.Visible;

        }

        /* Adaugare clienti in baza de date. */
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string getInputID;
            string getInputNume;
            string getInputPrenume;
            string getInputCNP;
            string getInputTelefon;

            /* Continue with code. */

        }

        /* Anulare operatie. */
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            inputID.Text = "";
            inputNume.Text = "";
            inputPrenume.Text = "";
            inputCNP.Text = "";
            inputTelefon.Text = "";
            radioButtonDA.IsChecked = false;
            radioButtonNU.IsChecked = false;
        }

        private void Clienti_Click_Mod(object sender, RoutedEventArgs e)
        {

        }

        private void Clienti_Click_Del(object sender, RoutedEventArgs e)
        {

        }

        private void Clienti_Click_Viz(object sender, RoutedEventArgs e)
        {

        }

        private void Activitati_Click_Add(object sender, RoutedEventArgs e)
        {

        }

        private void Activitati_Click_Mod(object sender, RoutedEventArgs e)
        {

        }

        private void Activitati_Click_Del(object sender, RoutedEventArgs e)
        {

        }

        private void Activitati_Click_Viz(object sender, RoutedEventArgs e)
        {

        }

        private void Rezervari_Click_Add(object sender, RoutedEventArgs e)
        {

        }

        private void Rezervari_Click_Mod(object sender, RoutedEventArgs e)
        {

        }

        private void Rezervari_Click_Del(object sender, RoutedEventArgs e)
        {

        }

        private void Rezervari_Click_Viz(object sender, RoutedEventArgs e)
        {

        }

    }
}
