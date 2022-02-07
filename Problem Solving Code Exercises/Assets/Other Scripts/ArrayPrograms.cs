using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPrograms : MonoBehaviour
{
    int[] userarray = new int[] { 2, 6, 99, 5, -2, 45, 0 };
    void Start()
    {

        // Findind the largest and the smallest values
        int largest = -999999;
        int smallest = 999999;
        largest = userarray[0];
        smallest = userarray[0];
        int counter = 0;
        int indexnum=0;
        for (int i=0; i<userarray.Length; i++)
        {
            if(userarray[i] > largest)
            {
                largest = userarray[i];
            }
            if(userarray[i] < smallest)
            {
                smallest = userarray[i];
            }
        }
        print("The largest number in the array is: " + largest + "\nThe smallest number in the array is: " + smallest);

        // Sorting the array
        int[] temparray = new int[] {0, 0, 0, 0, 0, 0, 0};
        smallest = userarray[0];
        while (counter<userarray.Length)
        {
            for (int i = 0; i < userarray.Length; i++)
            {
                if (userarray[i] < smallest)
                {
                    smallest = userarray[i];
                    indexnum = i;
                }
            }
            //print(counter);
            temparray[counter] = smallest;
            counter++;
            smallest = 999999;
            userarray[indexnum] = 99999;
        }
        userarray = temparray;
        for(int i=0; i<userarray.Length; i++)
        {
            print(userarray[i]);
        }
    }
}
