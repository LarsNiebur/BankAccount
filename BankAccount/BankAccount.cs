using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        public string Number  { get; private set; }
        public string Owner   { get; private set; }
        public float  Balance { get; private set; }

        public BankAccount( string number, string owner, float initialBalance ) 
        { 
            this.Number  = number;
            this.Owner   = owner;
            this.Balance = initialBalance;
        }

        public void MakeDeposit( float amount )
        {
            this.Balance += amount;
        }

        public void MakeWithdrawal ( float amount ) 
        {
            if ( amount <= this.Balance )
            {
                this.Balance -= amount;
            } 
            else
            {
                Console.WriteLine("Unzureichender Saldo");
            }
        }

        public void PrintBalance ()
        {
            Console.WriteLine($"Kontostand von {this.Owner}: {this.Balance}");
        }
    }
}
