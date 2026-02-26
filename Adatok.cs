using System;
using System.IO;
using System.Collections.Generic;


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
		using (StreamWriter pontok = new StreamWriter("pontok.txt"))
		{
			foreach (int jatekosokSzama in JatekosSzam)
			{
				pontok.WriteLine($"{jatekos.Nev}; {jatekos.Tet}");
            }
        }
	}
}
