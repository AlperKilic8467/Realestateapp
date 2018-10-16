using System;
using System.Collections.Generic;
using System.Text;
using Uppg1BLL.buildinfiles;

namespace Uppg1BLL
{
    [Serializable]
    public class Appartment : Building
    {
        public Appartment(string Cat, Adress Adress, string AppartFloor, string Type) :
            base(Cat, Adress)
        {
            this.AppartFloor = AppartFloor;
            this.Type = Type;
        }
        public string AppartFloor { get; set; }
        public string Type { get; set; }

        //For presenting the Appartment
        public override string ToString()
        {
            return base.ToString() + " " + Type + " on floor number: "  + AppartFloor + " " + Adress.ToString();
        }

    }
}
