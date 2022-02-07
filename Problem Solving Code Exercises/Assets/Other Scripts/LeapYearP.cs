using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapYearP : MonoBehaviour
{
    public int year;
    void Start()
    {
        // with nested ifs
        if(year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    print("The year " + year + " is a leap year.");
                } else
                {
                    print("The year " + year + " is not a leap year.");
                }
            } else
            {
                print("The year " + year + " is a leap year.");
            }
        } else
        {
            print("The year " + year + " is not a leap year.");
        }

        // with conditionals
        if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
        {
            print("The year " + year + " is a leap year.");
        }
        else if (year % 4 == 0 && year % 100 != 0)
        {
            print("The year " + year + " is a leap year.");
        } else
        {
            print("The year " + year + " is not a leap year.");
        }
    }

}
