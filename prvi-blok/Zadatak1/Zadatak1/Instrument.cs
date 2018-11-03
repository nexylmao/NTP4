using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public enum InstrumentTip { zicani, duvacki, udaracki, kombinovani };

    public abstract class Instrument
    {
        protected InstrumentTip tip;
        public InstrumentTip Tip
        {
            get => tip;
        }

        protected string muzicar;
        public string Muzicar
        {
            get => muzicar;
        }

        public Instrument(InstrumentTip tip, string muzicar)
        {
            this.tip = tip;
            this.muzicar = muzicar;
        }

        public abstract string Sviraj();

        public static readonly string SvirajFormat = "Trenutno svira {0} ({1})";
    }

    public class Violina : Instrument
    {
        public Violina(string muzicar) : base(InstrumentTip.zicani, muzicar) { }
        public override string Sviraj() => string.Format(SvirajFormat, Muzicar, "Violina");
    }

    public class Kontrabas : Instrument
    {
        public Kontrabas(string muzicar) : base(InstrumentTip.zicani, muzicar) { }
        public override string Sviraj() => string.Format(SvirajFormat, Muzicar, "Kontrabas");
    }

    public class Frula : Instrument
    {
        public Frula(string muzicar) : base(InstrumentTip.duvacki, muzicar) { }
        public override string Sviraj() => string.Format(SvirajFormat, Muzicar, "Frula");
    }

    public class Saksofon : Instrument
    {
        public Saksofon(string muzicar) : base(InstrumentTip.duvacki, muzicar) { }
        public override string Sviraj() => string.Format(SvirajFormat, Muzicar, "Saksofon");
    }
}
