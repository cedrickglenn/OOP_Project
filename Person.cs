using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Person
    {
        public string FirstName = "";
        public string MiddleInitial;
        public string LastName = "";
        public string BirthDate;
        public string Address;

        public Person (string firstName, string lastName, string middleName= "")
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleInitial = middleName;
        }
        
        public string GetFullName()
        {
            string fName = "";
            string lName = "";
            char letter1;
            char letter2;
            string partName = "";

            string[] fNameArray = FirstName.Split(' ');
            for (int count1 = 0; count1 < fNameArray.Length; count1++)
            {
                if (char.IsLower(fNameArray[count1][0]))
                {
                    letter1 = char.ToUpper(fNameArray[count1][0]);
                }
                else
                {
                    letter1 = fNameArray[count1][0];
                }
                for (int count2 = 1; count2 < fNameArray[count1].Length; count2++)
                {
                    if (char.IsLower(fNameArray[count1][count2]))
                    {
                        letter2 = fNameArray[count1][count2];
                    }
                    else
                    {
                        letter2 = char.ToLower(fNameArray[count1][count2]);
                    }
                    partName = partName + letter2;
                }
                fNameArray[count1] = letter1 + partName;
                fName = fName + fNameArray[count1] + " ";
                partName = "";
            }
            string[] lNameArray = LastName.Split(' ');
            for (int count1 = 0; count1 < lNameArray.Length; count1++)
            {
                if (char.IsLower(lNameArray[count1][0]))
                {
                    letter1 = char.ToUpper(lNameArray[count1][0]);
                }
                else
                {
                    letter1 = lNameArray[count1][0];
                }
                for (int count2 = 1; count2 < lNameArray[count1].Length; count2++)
                {
                    if (char.IsLower(lNameArray[count1][count2]))
                    {
                        letter2 = lNameArray[count1][count2];

                    }
                    else
                    {
                        letter2 = char.ToLower(lNameArray[count1][count2]);
                    }
                    partName = partName + letter2;
                }
                lNameArray[count1] = letter1 + partName;
                lName = lName + lNameArray[count1] + " ";
                partName = "";
            }
            return fName + char.ToUpper(MiddleInitial[0]) + ". " + lName;
        }


        public int GetAge()
        {

            return Calculations.CalculateAge(BirthDate);
        }
    }
}
