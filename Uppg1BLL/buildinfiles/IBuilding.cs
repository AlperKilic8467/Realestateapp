﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uppg1BLL.buildinfiles
{
    public interface IBuilding
    {
        //int BuildID { get; set; }
        string Cat { get; set; }
        Adress Adress { get; set; }

     //   void GetBuilding(int BuildID);
    }
}
