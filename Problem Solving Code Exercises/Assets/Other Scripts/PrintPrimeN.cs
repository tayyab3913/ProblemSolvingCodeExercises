using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPrimeN : MonoBehaviour
{
    public int number;
    void Start()
    {
        int count = number;
        int primecount=0;
        int counter;
        while(primecount<count)
        {
            bool isPrime = false;
            counter = 2;
            while (counter < (number / 2))
            {
                if (number % counter == 0)
                {
                    isPrime = true;
                }
                counter++;
            }

            if (isPrime)
            {
                print("The number " + number + " is a prime number.");
            }
            else
            {
                print("The number " + number + " is not a prime number.");
            }
            primecount++;
        }
    }
}
