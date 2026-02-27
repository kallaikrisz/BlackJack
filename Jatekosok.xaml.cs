using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for JatekosSzam.xaml
    /// </summary>
    public partial class JatekosSzam : Window
    {
        public JatekosSzam()
        {
            InitializeComponent();
            txtJatekosSzam.PreviewTextInput += TxtJatekosSzam_PreviewTextInput;
        }
        private void TxtJatekosSzam_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out _);
        }

        private void txtJatekosSzam_TextChanged(object sender, TextChangedEventArgs e)
        {
            NevStackPanel.Children.Clear();

            if (int.TryParse(txtJatekosSzam.Text, out int jatekosokSzama))
            {
                if (jatekosokSzama <= 0 || jatekosokSzama > 8)
                    return;

                for (int i = 1; i <= jatekosokSzama; i++)
                {
                    StackPanel sor = new StackPanel
                    {
                        Orientation = Orientation.Horizontal,
                        Margin = new Thickness(0, 5, 0, 5)
                    };

                    TextBlock label = new TextBlock
                    {
                        Text = $"{i}. játékos neve:",
                        Width = 150,
                        VerticalAlignment = VerticalAlignment.Center,
                        Foreground = System.Windows.Media.Brushes.White  
                    };

                    TextBox textBox = new TextBox
                    {
                        Width = 150,
                        Foreground = System.Windows.Media.Brushes.White,  
                        Background = System.Windows.Media.Brushes.Black   
                    };

                    sor.Children.Add(label);
                    sor.Children.Add(textBox);

                    NevStackPanel.Children.Add(sor);
                }

            }
            else
            {
                MessageBox.Show("Kérlek számot adj meg!");
            }
        }
        private void Tovabb_Click(object sender, RoutedEventArgs e)
        {

            foreach (StackPanel sor in NevStackPanel.Children)
            {
                foreach (var elem in sor.Children)
                {
                    if (elem is TextBox tb)
                    {
                        if (!string.IsNullOrWhiteSpace(tb.Text))
                        {
                            Adatok aktualis = new Adatok();
                            aktualis.Nev = tb.Text;
                            aktualis.Egyenleg = 10000;
                            aktualis.Tet = 0;
                            ((App)Application.Current).jatekosNevek.Add(aktualis);
                        }
                    }
                }
            }


            Tetek ujAblak = new Tetek();
            ujAblak.Show();

            this.Close();
        }
    }
}