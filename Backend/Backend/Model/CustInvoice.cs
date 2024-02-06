﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Model
{
    public class CustInvoice
    {
        public int Id { get; set; }
        public string Invoice { get; set; }
        public string Bill_To { get; set; }
        public string Ship_To { get; set; }
        public string Contact_Person { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Date { get; set; }
        public int Qty { get; set; }
        public decimal Unit_Price { get; set; }
        public string Particulars { get; set; }
    }
}
