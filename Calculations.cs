using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Calculations
    {
        public static int CalculateAge(string birthDate, bool returnInMonths = false)
        {
            int age;

            DateTime now = Convert.ToDateTime("11/26/2018");
            DateTime past = Convert.ToDateTime(birthDate);


            if (returnInMonths)
                age = (now.Year - past.Year) * 12 + (now.Month - past.Month);
            else
                age = (now.Year - past.Year) + (now.Month - past.Month) / 12;

            return Math.Abs(age);
        }
        public static decimal CalculateInterest(decimal principalAmount, decimal monthlyRate)
        {
            decimal interest = principalAmount * (monthlyRate / 100) * 100;
            return Convert.ToInt32(interest);
        }
        public static decimal CalculateAccruedAmount(decimal principalAmount, decimal monthlyRate, string date, int numberOfItems)
        {
            decimal accruedAmount = principalAmount * numberOfItems + (CalculateInterest(principalAmount, monthlyRate) * CalculateAge(date, true));
            return Convert.ToInt32(accruedAmount);
        }
    }
}
