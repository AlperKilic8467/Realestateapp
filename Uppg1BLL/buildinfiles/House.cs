using System;
using System.Collections.Generic;
using System.Text;
using Uppg1BLL.buildinfiles;

namespace Uppg1BLL
{
    [Serializable]
    public class House : Building
    {
        public House(string Cat, Adress Adress, string PoolSize, string Type) :
            base(Cat, Adress)
        {
            this.PoolSize = PoolSize;
            this.Type = Type;
        }
        //todo
        public string PoolSize { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + Type + " Pool size: " + PoolSize + " " + Adress.ToString();
        }
    }

}
