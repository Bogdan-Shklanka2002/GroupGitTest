using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTest
{
    public class BusinessCard
    {
        public string Owner { get; set; }

        public string ShowOwner()
        {
            return "Owner: " + Owner;
        }
    }
}
