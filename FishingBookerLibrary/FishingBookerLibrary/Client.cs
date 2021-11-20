﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBookerLibrary
{
    public class Client : RegUser
    {
        public ClientCategoryType ClientCategory { get; set; }
        public int NumberOfPenalties { get; set; } = 0;
    }
}
