using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FishingBookerLibrary.Models
{
    public class RegUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Biography { get; set; }// = "/";
        public float TotalScalePoints { get; set; }// = 0;
        public string Status { get; set; }// = "Waiting";
        public float Rating { get; set; }// = 0;
        public float RatingSum { get; set; }// = 0;
        public float RatingCount { get; set; }// = 0;
        public int Penalties { get; set; }// = 0;
    }
}
