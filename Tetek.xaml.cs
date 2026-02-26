using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlackJack
{
    public partial class Tetek : Window
    {
        private List<TextBox> tetTextBoxek = new List<TextBox>();

        public Tetek()
        {
            InitializeComponent();
            JatekosTetekLetrehozasa();
        }

        private void JatekosTetekLetrehozasa()
        {
            var jatekosNevek = ((App)Application.Current).jatekosNevek;

            for (int i = 0; i < jatekosNevek.Count; i++)
            {
                StackPanel sor = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    Margin = new Thickness(0, 8, 0, 8),
                    HorizontalAlignment = HorizontalAlignment.Center
                };

                Label nevLabel = new Label
                {
                    Content = $"{i + 1}. {jatekosNevek[i].Nev}:",
                    Width = 150,
                    Foreground = System.Windows.Media.Brushes.White,
                    Background = System.Windows.Media.Brushes.DarkSlateGray,
                    FontWeight = FontWeights.Bold,
                    FontSize = 14,
                    BorderBrush = System.Windows.Media.Brushes.Gray,
                    BorderThickness = new Thickness(1),
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(0, 0, 10, 0)
                };

                TextBox tetTextBox = new TextBox
                {
                    Width = 80,
                    Height = 30,
                    Text = "100",
                    Foreground = System.Windows.Media.Brushes.White,
                    Background = System.Windows.Media.Brushes.Black,
                    BorderBrush = System.Windows.Media.Brushes.Gold,
                    BorderThickness = new Thickness(2),
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    FontSize = 14,
                    FontWeight = FontWeights.Bold
                };

                tetTextBox.PreviewTextInput += (s, e) => e.Handled = !int.TryParse(e.Text, out _);

                tetTextBox.TextChanged += (s, e) =>
                {
                    if (int.TryParse(((TextBox)s).Text, out int tet) && tet <= 0)
                        ((TextBox)s).Text = "100";
                };


                tetTextBoxek.Add(tetTextBox);
                sor.Children.Add(nevLabel);
                sor.Children.Add(tetTextBox);
                TetStackPanel.Children.Add(sor);
            }
        }

        private bool TetekEllenorzese()
        {
            foreach (var tb in tetTextBoxek)
            {
                if (string.IsNullOrWhiteSpace(tb.Text) || !int.TryParse(tb.Text, out int tet) || tet <= 0)
                {
                    MessageBox.Show("Kérlek érvényes pozitív számot adj meg minden tétnél!", "Hiba");
                    return false;
                }
            }
            return true;
        }

        private void Tovabb_Click(object sender, RoutedEventArgs e)
        {
            if (!TetekEllenorzese()) return;

            var app = (App)Application.Current;
            app.jatekosTetek.Clear();
            app.jatekosTetek.AddRange(tetTextBoxek.Select(tb => int.Parse(tb.Text)));

            int osszeg = app.jatekosTetek.Sum();
            MessageBox.Show($"Tétek elmentve! Összesen: {osszeg}", "Siker");

            // Open the application's main window
            MainWindow mainWindow = new MainWindow();
            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
            this.Close();
        }
    }
}