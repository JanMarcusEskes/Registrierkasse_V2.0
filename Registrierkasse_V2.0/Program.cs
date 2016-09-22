using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registrierkasse_V2._0
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "PayOS";
      char euro = (char)128;
      double gesamtpreis = 0, MwST;
      double[] preis = new double[1000];
      string[] name = new string[1000];
      int i = 0;
      int c = 0;
      string eingabe;
      Console.WriteLine("Willkommen bei PayOS");
      Console.WriteLine("Bitte geben Sie den Namen des Artikels ein");
      eingabe = Console.ReadLine();
      while (eingabe != "x")
      {
        name[i] = eingabe;
        Console.WriteLine("Bitte geben Sie jetzt den Preis des Artikels ein");
        if (Double.TryParse(eingabe = Console.ReadLine(), out preis[i]) && Double.Parse(eingabe) >= 0) ;
        else { Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Es wurde ein ungültiger Preis eingegeben!"); Console.ReadLine(); return; }
        i++;
        Console.Clear();
        Console.WriteLine("Willkommen bei PayOS");
        Console.WriteLine("Bitte geben Sie jetzt den Namen des nächsten Artikels ein");
        eingabe = Console.ReadLine();
      }
      if (i == 0) { Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Es wurde kein Artikel eingegeben!"); Console.ReadLine(); return; }
      Console.Clear();
      Console.WriteLine("Ihre Eingaben waren:");
      Console.WriteLine("");
      while (c < i)
      {
        gesamtpreis = gesamtpreis + preis[c];
        Console.WriteLine(preis[c] + "    " + name[c]);
        c++;
      }
      Console.WriteLine("---------------------------");
      MwST = gesamtpreis * 0.19;
      Console.WriteLine("Zwichenbetrag : " + Math.Round(gesamtpreis, 2) + " Euro");
      Console.WriteLine("Mehrwertsteuer: " + Math.Round(MwST, 2) + " Euro");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Gesammtpreis  : " + Math.Round(gesamtpreis + MwST, 2) + " Euro");
      Console.ReadLine();
    }
  }
}
