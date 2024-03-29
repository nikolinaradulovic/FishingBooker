﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBookerLibrary.Models
{
    public class Cottage : Entity
    {
        public CottageReservation FastReservation { get; set; }
        public int NumberOfRooms { get; set; }
        public int BedsPerRoom { get; set; }
        public string OwnerId { get; set; }
    }
}
