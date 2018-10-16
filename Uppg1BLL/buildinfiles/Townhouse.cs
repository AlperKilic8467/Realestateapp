using System;
using System.Collections.Generic;
using System.Text;
using Uppg1BLL.buildinfiles;

namespace Uppg1BLL
{
    [Serializable]
    public class Townhouse : Building
    {
        public Townhouse(string Cat, Adress Adress, string NbrOfNeighbors, string Type) :
            base(Cat, Adress)
        {
            this.NbrOfNeighbors = NbrOfNeighbors;
            this.Type = Type;
        }
        public string NbrOfNeighbors { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + Type + " Number of neighbors: " + NbrOfNeighbors + " " + Adress.ToString();
        }
    }
}
