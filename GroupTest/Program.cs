using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            BusinessCard businessCard = new BusinessCard();

            businessCard.Owner = "John"; 
            Console.WriteLine($"Owner of card: {businessCard.Owner}"); //hello world

        }
    }
}
