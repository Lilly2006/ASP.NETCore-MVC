﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TutorialAppCore.Models
{
    public class CargoSystem
    {
        

        public string Customer_Name { get; set; }
        [Key]
        public int Customer_Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public int Ph_No { get; set; }
    }
}
