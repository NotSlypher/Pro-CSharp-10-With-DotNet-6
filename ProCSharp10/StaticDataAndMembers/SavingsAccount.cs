using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    public class SavingsAccount
    { 

        //A static point of data
        public static double currInterestRate = 0.04;

        public double currBalance;

        static SavingsAccount()
        {
            Console.WriteLine("in static constructor");
            currInterestRate = 0.04;
        }

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate() {
            return currInterestRate;
        }
    }
}
