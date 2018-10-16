using System;
using System.Collections.Generic;
using System.Text;
using Uppg1BLL.buildinfiles;

namespace Uppg1BLL
{
    [Serializable]
    public abstract class Building : IBuilding
    {
        //Getters and setters for properies of Building
        private static int IDcount = 0;

        public int BuildID { get; set; }
        public string Cat { get; set; }
        public Adress Adress { get; set; }

        //Constructor
        public Building(string Cat, Adress Adress)
        {
            IDcount++;
            this.BuildID = IDcount;
            this.Cat = Cat;
            this.Adress = Adress;
        }
        //For presenting the building
        public override string ToString()
        {
            return Cat ;
        }
    }
}
