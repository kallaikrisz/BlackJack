using System;
using System.IO;
using System.Collections.Generic;
using BlackJack;
using System.Windows;


public class Adatok
{
	public string Nev { get; set; }
	public int Tet { get; set; }
	public int Egyenleg { get; set; }
}

public class txtbe
{
    public void pontmentes(List<Adatok> jatekosok)
	{
        int jatekosokszama = ((App)Application.Current).jatekosSzamok;
        using (StreamWriter pontok = new StreamWriter("pontok.txt"))
        {
            foreach (Adatok jatekos in jatekosok.Take(jatekosokszama))
            {
                pontok.WriteLine($"{jatekos.Nev};{jatekos.Tet}");
            }
        }
    }
}
