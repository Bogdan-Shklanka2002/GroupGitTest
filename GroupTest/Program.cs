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
            CreditCard CreditCard = new CreditCard { CVV = 300, Number = "2692 2985 8258 9235" };

            Money money = new Money();
            money.Balance = 500;
            BusinessCard businessCard = new BusinessCard();

            businessCard.Owner = "John"; 
            Console.WriteLine($"Owner of card: {businessCard.Owner}"); //hello world

        }
    }
}
