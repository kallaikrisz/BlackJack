using System;
using System.IO;
using System.Collections.Generic;


public class ponttxt
{
	public void pontmentes(List<Jatekos> jatekosok)
	{
		using (StreamWriter pontok = new StreamWriter("pontok.txt"))
		{
			foreach (Jatekos jatekos in jatekosok)
			{
				pontok.WriteLine($"{jatekos.Nev} {jatekos.Pontszam}");
            }
        }
	}
}
