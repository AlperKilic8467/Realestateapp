using System;
using System.Collections.Generic;
using System.Text;
using Uppg1BLL.buildinfiles;

namespace Uppg1BLL
{
    [Serializable]
    public class Warehouse : Building
    {
        public string Height { get; set; }
        public string Type { get; set; }

        public Warehouse(string Cat, Adress Adress, string Height, string Type) :
            base(Cat, Adress)
        {
            this.Height = Height;
            this.Type = Type;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Type + " Height of warehouse: " + Height + " " + Adress.ToString();
        }

    }
}
