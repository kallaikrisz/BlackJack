using System;
using System.IO;
using System.Collections.Generic;
using BlackJack;
using System.Windows;
using System.Linq;


public class Adatok
{
	public string Nev { get; set; }
	public int Tet { get; set; }
	public int Egyenleg { get; set; }
    public int pont { get; set; }
}

public class txtbe
{
    DateTime most = DateTime.Now;
    public void pontmentes(List<Adatok> jatekosok)
	{
        int jatekosokszama = ((App)Application.Current).jatekosAdatok.Count;
        using (StreamWriter pontok = new StreamWriter("pontok.txt"))
        {
            foreach (Adatok jatekos in jatekosok.Take(jatekosokszama))
            {
                pontok.WriteLine($"{most};{jatekos.Nev};{jatekos.Egyenleg}");
            }
        }
    }
}
