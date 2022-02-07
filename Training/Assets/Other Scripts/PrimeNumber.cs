using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeNumber : MonoBehaviour
{
    int counter = 2;
    public int number;
    void Start()
    {
        bool isPrime = false;
        while (counter < (number/2))
        {
            if (number % counter == 0)
            {
                isPrime = true;
            }
            counter++;
        }

        if(isPrime)
        {
            print("The number " + number + " is a prime number.");
        } else
        {
            print("The number " + number + " is not a prime number.");
        }
    }

}
