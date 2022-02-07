using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smg : Gun
{
    public Smg() : base(8, 15, "Smg")
    {

    }
    void Shoot()
    {
        Debug.Log("Smg Shot");
    }
}
