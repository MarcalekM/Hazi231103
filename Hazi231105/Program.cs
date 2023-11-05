using System.Collections.Generic;

namespace Hazi231105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Szoftver> szoftverek = new();
            using StreamReader sr = new(
                path: @"..\..\..\src\szoftverek.txt",
                encoding: System.Text.Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) szoftverek.Add(new(sr.ReadLine()));
            foreach(var sz in szoftverek)
            {
                Console.WriteLine(sz.ToString());
            }
            Console.WriteLine("7. feladat:");
            var f7 = szoftverek.Where(sz => sz.Kategoria.Equals("antivírus") && sz.Ertekeles >= 8.5);
            Console.WriteLine($"\t{f7.Count()} db 8,5-nél magasabb értélelésű antivírus szoftver van");

            Console.WriteLine("8. feladat:");
            double max = szoftverek.Max(sz => sz.Ertekeles);
            var f8 = szoftverek.Where(sz => sz.Ertekeles.Equals(max - 0.1));
            foreach (var f in f8)
            {
                Console.WriteLine(f.ToString());
            }
            Console.WriteLine($"A keresett átlag:  {max - 0.1}");

            Console.WriteLine("10. feladat:");
            var f10 = szoftverek.Where(sz => sz.Nev.Contains("Adobe"));
            double atlag = 0;
            foreach (var f in f10)
            {
                atlag += f.Brutto(f.Ar, f.AdoKulcs);
            }
            Console.WriteLine($"Az Adobe szoftverek átlag bruttó érétke {atlag / f10.Count()} USD");

            Console.WriteLine("11. feladat:");
            var f11 = szoftverek.Where(sz => sz.OPrendszerek.Length >= 2);
            f11 = f11.OrderBy(sz => sz.Kategoria);
            foreach (var f in f11)
            {
                Console.WriteLine(f.Kategoria);
            }

            Console.WriteLine("12. feladat:");

            Console.ReadLine();
        }
    }
}