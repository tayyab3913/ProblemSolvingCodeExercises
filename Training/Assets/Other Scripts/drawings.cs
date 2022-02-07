using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawings : MonoBehaviour
{
    public int number;
    string stars = "";
    void Start()
    {
        int counter = 1;
        //First Triangle
        for(int j = 1; j<=number; j++)
        {
            stars = "";
            for (int i = 0; i < j; i++)
            {
                stars = stars + "*";
            }
            print(stars + "\n");
        }

        //Second Triangle
        for (int j = number; j >= 1; j--)
        {
            stars = "";
            for (int i = 0; i < j; i++)
            {
                stars = stars + "*";
            }
            print(stars + "\n");
        }

        //Third Triangle
        for (int j = 1; j <= number; j++)
        {
            stars = "";
            for(int i = number-counter; i>0; i--)
            {
                stars = stars + " ";
            }
            for(int i = 0; i < counter; i++)
            {
                stars = stars + "*";
            }
            counter++;
            print(stars + "\n");
        }

        //Square
        for (int j = 1; j <= number; j++)
        {
            stars = "";
            for (int i = 0; i < number; i++)
            {
                stars = stars + "*";
            }
            print(stars + "\n");
        }

        //Hollow Square
        for (int j = 1; j <= number; j++)
        {
            if (j == 1 || j == number)
            {
                stars = "";
                for (int i = 0; i < number; i++)
                {
                    stars = stars + "*";
                }
            }
            else
            {
                stars = "*";
                for (int i = 0; i < number-2; i++)
                {
                    stars = stars + " ";
                }
                stars = stars + "*";
            }           
            print(stars + "\n");
        }
    }
}
