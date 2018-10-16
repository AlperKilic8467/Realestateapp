using System;
using System.Collections.Generic;
using System.Text;
using Uppg1BLL.buildinfiles;

namespace Uppg1BLL
{
    [Serializable]
    public class Shop : Building
    {
        public string NbrOfRegisters { get; set; }
        public string Type { get; set; }

        public Shop(string Cat, Adress Adress, string NbrOfRegisters, string Type) :
            base(Cat, Adress)
        {
            this.NbrOfRegisters = NbrOfRegisters;
            this.Type = Type;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Type + " Number of registers in shop; " + NbrOfRegisters + " " + Adress.ToString();
        }

    }
}
