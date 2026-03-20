using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var jatekosNevek = ((App)Application.Current).jatekosAdatok;

            // Nevek feltöltése
            for (int i = 0; i < jatekosNevek.Count; i++)
            {
                switch (i)
                {
                    case 0: j1nev.Content = jatekosNevek[i].Nev; break;
                    case 1: j2nev.Content = jatekosNevek[i].Nev; break;
                    case 2: j3nev.Content = jatekosNevek[i].Nev; break;
                    case 3: j4nev.Content = jatekosNevek[i].Nev; break;
                    case 4: j5nev.Content = jatekosNevek[i].Nev; break;
                    case 5: j6nev.Content = jatekosNevek[i].Nev; break;
                    case 6: j7nev.Content = jatekosNevek[i].Nev; break;
                    case 7: j8nev.Content = jatekosNevek[i].Nev; break;
                }
            }

            var jatekosTetek = ((App)Application.Current).jatekosAdatok;

            for (int i = 0; i < jatekosNevek.Count; i++)
            {
                switch (i)
                {
                    case 0: j1tet.Content = jatekosTetek[i].Tet; break;
                    case 1: j2tet.Content = jatekosTetek[i].Tet; break;
                    case 2: j3tet.Content = jatekosTetek[i].Tet; break;
                    case 3: j4tet.Content = jatekosTetek[i].Tet; break;
                    case 4: j5tet.Content = jatekosTetek[i].Tet; break;
                    case 5: j6tet.Content = jatekosTetek[i].Tet; break;
                    case 6: j7tet.Content = jatekosTetek[i].Tet; break;
                    case 7:
                        j8tet.Content = jatekosTetek[i].Tet; break;
                }
            }

            int AtvettP = 0;
            Label[] nevek = { j1nev, j2nev, j3nev, j4nev, j5nev, j6nev, j7nev, j8nev };
            for (int i = 0; i < 8; i++)
            {
                if (i < jatekosNevek.Count && jatekosNevek[i].Nev != "")
                {
                    nevek[i].Content = jatekosNevek[i].Nev;
                    AtvettP++;
                }
            }

            for (int k = 0; k < AtvettP; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    jatekosNevek[k].RandomKartyaGen(); 
                }
            }
        }
    }
}
