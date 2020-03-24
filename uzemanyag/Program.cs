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
            F05();
            F06();
            Console.ReadKey();
        }

        private static void F06()
        {
            bool szkn = arak.Any(
                a => a.Valtozas.Year % 4 == 0
                && a.Valtozas.Month == 2
                && a.Valtozas.Day == 24);

            szkn = arak.Any(a => a.Szokonap);

            Console.WriteLine(szkn ? "van " : "nincs " + "szökőnapon változás");
        }

        private static void F05()
        {
            int c = arak.Count(
                a => Math.Abs(a.Benzin - a.Gazolaja)
                == arak.Min(
                    b => Math.Abs(b.Benzin - b.Gazolaja)));

            c = arak.Count(a => a.Diferencial == arak.Min(b => b.Diferencial));
            c = arak.Count(a => a.Diferencial == minv);

            Console.WriteLine($"ennyiszer volt: {c}");
        }

        private static void F04()
        {
            int minv = arak.Min(a => Math.Abs(a.Benzin - a.Gazolaja));
            minv = arak.Min(a => a.Diferencial);
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
