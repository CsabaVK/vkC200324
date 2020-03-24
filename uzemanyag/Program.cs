using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace uzemanyag
{
    
    class Program
    {
        static List<Ar> arak;
        static void Main(string[] args)
        {
            Beolvas();
            F03();
            F04();
            Console.ReadKey();
        }

        private static void F04()
        {
            int minv = arak.Min(a => Math.Abs(a.Benzin - a.Gazolaja));
            Console.WriteLine(minv);
        }

        private static void F03()
        {
            Console.WriteLine($"f3: {arak.Count}");
        }

        private static void Beolvas()
        {
            arak = new List<Ar>();
            var sr = new StreamReader(@"uzemanyag.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                arak.Add(new Ar(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
