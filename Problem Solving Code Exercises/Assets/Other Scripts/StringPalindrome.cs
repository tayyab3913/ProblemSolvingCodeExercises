using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringPalindrome : MonoBehaviour
{
    public string userString = "";
    void Start()
    {
        int firstStartIndex = 0;
        int firstStopIndex = (userString.Length / 2) - 1;
        int secondStartIndex = (userString.Length / 2) + 1;
        int secondStopIndex = userString.Length - 1;

        //print("The input string is a Palindrom: " + CheckStringPalindrom(userString));

        //print(ReverseStringWithIndex(userString, 1, 4));
        //print(ReturnStringWithIndex(userString, 1, 4));
        int subStringSize = 2;
        firstStartIndex = 0;
        secondStartIndex = subStringSize - 1;

            //for (int i = 0; i < userString.Length-1; i++)
            //{

            //    if (CheckStringPalindromWithIndex(userString, firstStartIndex, secondStartIndex))
            //    {
            //        print("The sub string (" + ReturnStringWithIndex(userString, firstStartIndex, secondStartIndex) + ") is a Palindrom.");
            //    }
            //    firstStartIndex++;
            //    secondStartIndex++;
            //}


        while (subStringSize < userString.Length)
        {
            for (int i = 0; i < userString.Length - 1; i++)
            {
                if (CheckStringPalindromWithIndex(userString, firstStartIndex, secondStartIndex))
                {
                    print("The sub string (" + ReturnStringWithIndex(userString, firstStartIndex, secondStartIndex) + ") is a Palindrom.");
                }
                firstStartIndex++;
                secondStartIndex++;
            }
            subStringSize++;
        }

        //if (CalculateAsciiOfString(firstStartIndex, firstStopIndex, userString) == CalculateAsciiOfString(secondStartIndex, secondStopIndex, userString))
        //{
        //    print("The input string is a Palindrom");
        //}
        //else
        //{
        //    print("The input string is not a Palindrom");
        //}
    }

    bool CheckStringPalindrom(string userString)
    {
        if (ReverseString(userString) == userString)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool CheckStringPalindromWithIndex(string userString, int startIndex, int stopIndex)
    {
        if (ReverseStringWithIndex(userString, startIndex, stopIndex) == ReturnStringWithIndex(userString, startIndex, stopIndex))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    int CalculateAsciiOfString(int startIndex, int closeIndex, string userString)
    {
        int asciiCounter = 0;
        for(int i=startIndex; i<=closeIndex; i++)
        {
            asciiCounter += (int)userString[i];
        }
        return asciiCounter;
    }

    string ReverseString(string userString)
    {
        int reverseCounter = userString.Length-1;
        string tempString = "";
        char temp = '0';
        for(int i=0; i<userString.Length; i++)
        {
            temp = userString[reverseCounter];
            tempString += temp;
            reverseCounter--;
        }
        return tempString;
        //return tempString;
    }

    string ReverseStringWithIndex(string userString, int startIndex, int stopIndex)
    {
        int reverseCounter = stopIndex;
        string tempString = "";
        char temp = '0';
        for (int i = startIndex; i <= stopIndex; i++)
        {
            temp = userString[reverseCounter];
            tempString += temp;
            reverseCounter--;
        }
        return tempString;
        //return tempString;
    }

    string ReturnStringWithIndex(string userString, int startIndex, int stopIndex)
    {
        string tempString = "";
        char temp = '0';
        for(int i = startIndex; i<=stopIndex; i++)
        {
            temp = userString[i];
            tempString += temp;
        }
        return tempString;
    }
}
