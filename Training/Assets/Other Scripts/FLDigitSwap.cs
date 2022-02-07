using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLDigitSwap : MonoBehaviour
{
    public int number;
    int first, last, zerocount, temp;
    int i = 1;
    int dividend = 1;
    int temp2 = 0;
    int temp3 = 0;
    int answer = 0;
    void Start()
    {

        if (number < 10){ zerocount = 1; }
        else
        if (number < 100) { zerocount = 2; }
        else
        if (number < 1000) { zerocount = 3; }
        else
        if (number < 10000) { zerocount = 4; }
        else
        if (number < 100000) { zerocount = 5; }
        else
        if (number < 1000000) { zerocount = 6; }
        else
        if (number < 10000000) { zerocount = 7; }
        else
        if (number < 100000000) { zerocount = 8; }
        else
        if (number < 1000000000) { zerocount = 9; }

        while (i < zerocount)
        {
            dividend = dividend * 10;
            i++;
        }

        first = (number / dividend);
        print("First Digit: " + first);
        last = (number % 10);
        print("Last Digit: " + last);

        temp = (number % 10) * dividend;
        print("Last Digit to First empty: " + temp);
        temp2 = number % dividend;
        print("Without First Digit: " + temp2);
        temp3 = (temp2 + temp) /10;
        print("Without Last Digit: " + temp3);
        answer = (temp3 * 10) + first;
        print("Answer after swap: " + answer);
    }

}
