using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzemanyag
{
    class Ar
    {
        public Ar(string s)
        {
            var t = s.Split(';');
            Valtozas = DateTime.Parse(t[0]);
            Benzin = int.Parse(t[1]);
            Gazolaja = int.Parse(t[2]);
        }

        public DateTime Valtozas { get; set; }
        public int Benzin { get; set; }
        public int Gazolaja { get; set; }
        public int Diferencial => Math.Abs(Benzin - Gazolaja);
    }

}
