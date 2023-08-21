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

            clientMod.IsChecked = false;
            clientDel.IsChecked = false;
            clientViz.IsChecked = false;

            FormularAdaugare.Visibility = Visibility.Visible;
            FormularStergere.Visibility = Visibility.Collapsed;
            FormularModificare.Visibility = Visibility.Collapsed;
            FormularModif.Visibility = Visibility.Collapsed;
            StergereClient.Visibility = Visibility.Collapsed;
            FormularVizualizare.Visibility = Visibility.Collapsed;
            VizualizareClient.Visibility = Visibility.Collapsed;

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

        /* -------------------------------------------------------- */

        private void Clienti_Click_Mod(object sender, RoutedEventArgs e)
        {
            clientAdd.IsChecked = false;
            clientDel.IsChecked = false;
            clientViz.IsChecked = false;

            FormularAdaugare.Visibility = Visibility.Collapsed;
            FormularModificare.Visibility = Visibility.Visible;
            FormularModif.Visibility = Visibility.Collapsed;
            FormularStergere.Visibility = Visibility.Collapsed;
            StergereClient.Visibility = Visibility.Collapsed;
            FormularVizualizare.Visibility = Visibility.Collapsed;
            VizualizareClient.Visibility = Visibility.Collapsed;
        }

        /* Cautare Clienti si modificare. */
        private void cautareClient_Click(object sender, RoutedEventArgs e)
        {
            string getNumeClient;
            string getCNP_Client;

            /* In cazul in care il gaseste in baza de date.*/
            FormularModificare.Visibility = Visibility.Collapsed;
            FormularModif.Visibility = Visibility.Visible;
            VizualizareClient.Visibility = Visibility.Collapsed;

        }

        /* Anulare cautare si modificare. */
        private void anulareCautare_Click(object sender, RoutedEventArgs e)
        {
            getNume.Text = "";
            getCNP.Text = "";
        }

        /* -------------------------------------------------------- */

        private void Clienti_Click_Del(object sender, RoutedEventArgs e)
        {
            clientAdd.IsChecked= false;
            clientMod.IsChecked= false;
            clientViz.IsChecked= false;
            FormularStergere.Visibility = Visibility.Visible;
            StergereClient.Visibility = Visibility.Collapsed;
            FormularAdaugare.Visibility= Visibility.Collapsed;
            FormularModificare.Visibility = Visibility.Collapsed;
            FormularModif.Visibility = Visibility.Collapsed;
            FormularVizualizare.Visibility = Visibility.Collapsed;
            VizualizareClient.Visibility = Visibility.Collapsed;
        }

        /* Cautare si stergere clienti. */
        private void cautareClientx_Click(object sender, RoutedEventArgs e)
        {
            string getNumeClientDel;
            string getCNP_ClientDel;

            /* In cazul in care il gaseste in baza de date. */
            StergereClient.Visibility = Visibility.Visible;
            FormularStergere.Visibility = Visibility.Collapsed;
            VizualizareClient.Visibility = Visibility.Collapsed;
        }

        /* Anulare cautare si stergere clienti. */
        private void anulareCautarex_Click(object sender, RoutedEventArgs e)
        {
            getNumex.Text = "";
            getCNPx.Text = "";
        }

        /* -------------------------------------------------------- */

        private void Clienti_Click_Viz(object sender, RoutedEventArgs e)
        {
            clientAdd.IsChecked = false;
            clientMod.IsChecked= false;
            clientDel.IsChecked= false;
            FormularVizualizare.Visibility = Visibility.Visible;
            FormularStergere.Visibility = Visibility.Collapsed;
            StergereClient.Visibility = Visibility.Collapsed;
            FormularAdaugare.Visibility = Visibility.Collapsed;
            FormularModificare.Visibility = Visibility.Collapsed;
            FormularModif.Visibility = Visibility.Collapsed;
        }

        /* Cautare si vizualizare client.*/
        private void cautareClienty_Click(object sender, RoutedEventArgs e)
        {
            string getNumeClientViz;
            string getCNP_ClientViz;
            FormularVizualizare.Visibility = Visibility.Collapsed;
            VizualizareClient.Visibility = Visibility.Visible;
        }

        /* Anulare cautare si vizualizare*/
        private void anulareCautarey_Click(object sender, RoutedEventArgs e)
        {
            getNumey.Text = "";
            getCNPy.Text = "";
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

        private void modifButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancelButtonx_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
