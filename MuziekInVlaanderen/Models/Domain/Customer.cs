﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuziekInVlaanderen.Models.Domain
{
    public class Customer
    {
        #region Properties
        //add extra properties if needed
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        #endregion

        #region Constructors
        public Customer()
        {
        }
        #endregion

        #region Methods

        #endregion
    }
}
