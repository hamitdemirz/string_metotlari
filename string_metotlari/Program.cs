using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_metotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "csharp";
            string degisken2 = "charpp";

            //length
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //concat
            Console.WriteLine(String.Concat(degisken, "merhaba"));

            //compore, comporeto

            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.CompareTo(degisken, degisken2, true));
            Console.WriteLine(String.CompareTo(degisken, degisken2, false));

            //contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("hosgeldiniz"));
            Console.WriteLine(degisken.StartsWith("merhaba"));

            //indexof
            Console.WriteLine(degisken.IndexOf("cs"));
            Console.WriteLine(degisken.IndexOf("hamit"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //insert
            Console.WriteLine(degisken.Insert(0, "Merhaba"));

            //padleft, padright
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //remove

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));

            //replace
            Console.WriteLine(degisken.Replace("csharp", "csharpp"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //split
            Console.WriteLine(degisken.Split(' ')[1]);
            //substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
        

        }
    }
}
