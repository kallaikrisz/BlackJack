using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public List<Adatok> jatekosNevek = new List<Adatok>();

        public List<int> jatekosTetek = new List<int>();

        public int jatekosSzamok = 0;
    }
}
