using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for Top10.xaml
    /// </summary>
    public partial class Top10 : Window
    {
        public class Pontok
        {
            public DateTime datum { get; set; }
            public string nev { get; set; }
            public int egyenleg { get; set; }

            public Pontok(string sor)
            {
                string[] darabol = sor.Split(";");
                datum = DateTime.Parse(darabol[0]);
                nev = darabol[1];
                egyenleg = int.Parse(darabol[2]);
            }
        }
        public Top10()
        {
            InitializeComponent();
            List<Pontok> adatok = new List<Pontok>();
            foreach (string sor in File.ReadLines("pontok.txt"))
            {
                Pontok aktualis = new Pontok(sor);
                adatok.Add(aktualis);
            }
            for (int i = 0; i < 10 && adatok.Count > 0; i++)
            {
                int hely = 0;
                int legnagyobb = adatok[0].egyenleg;
                for (int j = 1; j < adatok.Count; j++)
                {
                    if (adatok[j].egyenleg > legnagyobb)
                    {
                        hely = j;
                        legnagyobb = adatok[j].egyenleg;
                    }
                }
                if (i == 0) j1.Content = adatok[hely].nev;
                if (i == 1) j2.Content = adatok[hely].nev;
                if (i == 2) j3.Content = adatok[hely].nev;
                if (i == 3) j4.Content = adatok[hely].nev;
                if (i == 4) j5.Content = adatok[hely].nev;
                if (i == 5) j6.Content = adatok[hely].nev;
                if (i == 6) j7.Content = adatok[hely].nev;
                if (i == 7) j8.Content = adatok[hely].nev;
                if (i == 8) j9.Content = adatok[hely].nev;
                if (i == 9) j10.Content = adatok[hely].nev;
                adatok.Remove(adatok[hely]);
            }
        }
    }
}