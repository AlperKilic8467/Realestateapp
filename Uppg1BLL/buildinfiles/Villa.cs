using System;
using System.Collections.Generic;
using System.Text;
using Uppg1BLL.buildinfiles;

namespace Uppg1BLL
{
    [Serializable]
    public class Villa : Building
    {
        public string NbrOfRooms { get; set; }
        public string Type { get; set; }

        public Villa(string Cat, Adress Adress, string NbrOfRooms, string Type) :
            base(Cat, Adress)
        {
            this.NbrOfRooms = NbrOfRooms;
            this.Type = Type;
        }
        public override string ToString()
        {
            return base.ToString() + " " + Type + " number of rooms: " + NbrOfRooms + " " + Adress.ToString();
        }
    }
}
