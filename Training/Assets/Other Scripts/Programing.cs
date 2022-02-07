using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Programing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 121;
        int first, second, third, number;

        third = (a % 100) % 10;
        second = (a % 100) / 10;
        first = a / 100;

        number = (third * 100) + (second * 10) + (first);
        print(number);

        if((char)a== (char)(number))
        {
            print("The given number " + a + " is a Palindrome.");
        } else
        {
            print("The given number " + a + " is not a Palindrome.");
        }
    }

}
