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

namespace Voorkeursmodule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string naam;
        public MainWindow()
        {
            InitializeComponent();

          
        }
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstVoorkeur.Items.Add("Programmeren");
            lstVoorkeur.Items.Add("Netwerkbeheer");
            lstVoorkeur.Items.Add("IOT");
            btnOK.Visibility = Visibility.Hidden;

        }

        private void txtNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnOK.Visibility = Visibility.Visible;

            if (txtNaam.Text.Length == 0)
                btnOK.Visibility = Visibility.Hidden;
            else
                btnOK.Visibility = Visibility.Visible;

            string naam = txtNaam.Text;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            string naam = txtNaam.Text;
            lblWelkom.Content = "Welkom in Howest " + naam;
           

        }

        private void lstVoorkeur_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string voorkeursRichting = (string)lstVoorkeur.SelectedItem;
            tbkFeedBack.Text = naam + " je voorkeur gaat uit naar " + voorkeursRichting;

        }
    }
}
