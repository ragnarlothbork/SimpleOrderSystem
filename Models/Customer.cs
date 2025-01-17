﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleOrderSystem.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public int SalesRepEmployeeNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string CreditLimit { get; set; }
        public Employee employee { get; set; }

      
    }
}