﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBookerLibrary
{
    public class CottageOwner : RegUser
    {
        public RegistrationType RegistrationType { get; set; }
        public string RegistrationDescription { get; set; }

    }
    
}