using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{
    class Boat : Transport
    {
        private int BruttoTonnasje;
        private int Maksfart;
        public Boat(string kjennetegn, int kw, string transportType, int brutto, int fart) : base(kjennetegn, kw, transportType)
        {
            BruttoTonnasje = brutto;
            Maksfart = fart;
        }

        public override void Show()
        {
            Console.WriteLine($"Kjennetegn: {Kjennetegn}, {Kw}Effekt, Maksfart: {Maksfart}, {BruttoTonnasje}KG Bruttotonnasje");
        }
        public override void Go()
        {
            base.Go();
        }
    }
}
