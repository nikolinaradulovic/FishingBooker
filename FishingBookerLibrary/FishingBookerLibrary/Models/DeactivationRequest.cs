using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBookerLibrary.Models
{
    public class DeactivationRequest
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string EmailAddress { get; set; }
        public string Reason { get; set; }
    }
}
