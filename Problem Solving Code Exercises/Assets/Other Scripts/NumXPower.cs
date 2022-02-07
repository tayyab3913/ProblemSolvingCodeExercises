using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumXPower : MonoBehaviour
{
    public int number;
    public int power;
    int answer = 1;
    void Start()
    {
        for(int counter=0; counter<power; counter++)
        {
            answer = answer*number;
        }
        print("Number " + number + " raised to the power " + power + " is " + answer + ".");
    }
}
